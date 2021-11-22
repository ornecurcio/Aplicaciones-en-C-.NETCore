using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = @"Server=localhost\SQLEXPRESS;Database=TpFinalCurcioOrnela;Trusted_Connection=True;";
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select
        public List<Paciente> ObtenerListaPacientes()
        {
            List<Paciente> lista = new List<Paciente>();

            try
            {
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM dbo.Paciente INNER JOIN dbo.PacientePatologia " +
                                      "ON paciente.dni = pacientepatologia.idpaciente " +
                                      "INNER JOIN Patologias ON PacientePatologia.idpatologia = Patologias.idpatologia " +
                                      "ORDER BY Dni Asc";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    double dni = double.Parse(lector["Dni"].ToString());
                    bool existe = lista.Exists((x) => x.Dni == dni);
                    if (!existe)
                    {
                        Paciente item = new Paciente();
                        item.Dni = double.Parse(lector["Dni"].ToString());
                        item.Apellido = lector["Apellido"].ToString();
                        item.Nombre = lector["Nombre"].ToString();
                        item.Edad = lector.GetInt32("Edad");
                        EPatologia aux = (EPatologia)Enum.Parse(typeof(EPatologia), lector["IdPatologia"].ToString());
                        item.Patologia.Add(aux);
                        lista.Add(item);
                    }
                    else
                    {
                        int id = lista.FindIndex((x) => x.Dni == dni); 
                        EPatologia aux = (EPatologia)Enum.Parse(typeof(EPatologia), lector["IdPatologia"].ToString());
                        lista[id].Patologia.Add(aux);
                    }
                }

                lector.Close();

            }
            catch (Exception)
            {
                throw; 
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return lista;
        }
        public List<Cirujano> ObtenerListaCirujanos()
        {
            List<Cirujano> lista = new List<Cirujano>();

            try
            {
                comando = new SqlCommand();
                string sql = "SELECT * FROM dbo.Cirujano INNER JOIN CirujanoRol " +
                    "ON Cirujano.dni = CirujanoRol.IdCirujano " +
                    "Order by Cirujano.DNI asc";
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql; 
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    Cirujano item = new Cirujano();
                    item.Dni = double.Parse(lector["DNI"].ToString());
                    item.Apellido = lector["Apellido"].ToString();
                    item.Nombre = lector["Nombre"].ToString();
                    item.Edad = lector.GetInt32("Edad");
                    item.Rol = (ERol)Enum.Parse(typeof(ERol), lector["IdRol"].ToString());
                    lista.Add(item);  
                }

                lector.Close();

            }
            catch (Exception)
            {
                throw; 
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return lista;
        }
        public List<Cirugia> ObtenerListaCirugias()
        {
            List<Cirugia> lista = new List<Cirugia>();

            try
            {
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM CIRUGIA INNER JOIN CIRUJANO " +
                                      "ON CIRUGIA.IDCIRUJANO = CIRUJANO.DNI INNER JOIN PACIENTE " +
                                      "ON CIRUGIA.IDPACIENTE = PACIENTE.DNI ORDER BY CIRUGIA.IDCIRUJANO Asc";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cirugia item = new Cirugia();
                    item.Cirujano = new Cirujano();
                    item.Cirujano.Nombre = lector[8].ToString();
                    item.Cirujano.Apellido = lector[7].ToString(); 
                    item.Cirujano.Dni = double.Parse(lector["IdCirujano"].ToString());
                    item.Cirujano.Edad = lector.GetInt32(9);
                    item.Cirujano.Rol = (ERol)Enum.Parse(typeof(ERol), lector["IdRol"].ToString());
                    item.Paciente = new Paciente(); 
                    item.Paciente.Dni = double.Parse(lector["IdPaciente"].ToString());
                    item.Paciente.Apellido = lector[11].ToString();
                    item.Paciente.Nombre = lector[12].ToString();
                    item.Paciente.Edad = lector.GetInt32(13);
                    item.Patologia = (EPatologia)Enum.Parse(typeof(EPatologia), lector["IdPatologia"].ToString());
                    item.Procedimiento = (EProcedimiento)Enum.Parse(typeof(EProcedimiento), lector["IdProcedimiento"].ToString());
                    item.Fecha = lector.GetDateTime(5); 
                    lista.Add(item);

                }

                lector.Close();

            }
            catch (Exception)
            {
                throw; 
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return lista;
        }


        #endregion

        #region Insert
        public bool ActualizarEstadisticaHospital(Estadistica param)
        {
            bool rta = true;

            try
            {
                string sql = "DELETE FROM dbo.EstadisticaHospital INSERT INTO dbo.EstadisticaHospital (columna, miembroSuperior, miembroInferior, pelvis, " +
                    "RAFI, ReduccionCerrada, Osteotomia, Artrodecis, Osteodesis, Yeso) " +
                    "VALUES(" + param.CantColumna.ToString() + "," + param.CantMiembroSuperior.ToString() + ","+
                              param.CantMiembroInferior.ToString() + ","+param.CantPelvis.ToString() + "," + 
                              param.CantRAFI.ToString() + ","+param.CantReduccionCerrada.ToString() + ","+ param.CantOsteotomia.ToString() + "," +
                              param.CantArtrodecis.ToString() + ","+ param.CantOsteodesis.ToString() + ","+ param.CantYeso.ToString()+ ")";

                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
        public bool AgregarPaciente(Paciente param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.Paciente (dni, apellido, nombre, edad) VALUES(";
                sql = sql + " " + param.Dni.ToString() + ",'"+ param.Apellido + "', '" + param.Nombre + "'," + param.Edad.ToString() + ")";

                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool AgregarPatologiaPaciente(Paciente param, EPatologia patologia)
        {
            bool rta = true;

            try
            {

                string sql = "INSERT INTO dbo.PacientePatologia (IdPaciente, IdPatologia) VALUES(" + param.Dni.ToString() + "," 
                              + ((int)patologia).ToString() + ")";

                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            { 
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool AgregarCirugia(Cirugia param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.Cirugia (IdCirujano, IdRol, IdPaciente, IdPatologia, IdProcedimiento, Fecha) " +
                             "VALUES(" + param.Cirujano.Dni.ToString()+", " +((int)param.Cirujano.Rol).ToString() + ", " + param.Paciente.Dni.ToString() + ", " +
                          ((int)param.Patologia).ToString() + ", " + ((int)param.Procedimiento).ToString() + ",'" + param.Fecha.ToString("yyyy-MM-dd") + "');";

                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool AgregarCirujano(Cirujano param)
        {
            bool rta = true;

            try
            {
                
                comando = new SqlCommand();
                string sql = 
                "INSERT INTO dbo.Cirujano (dni, apellido, nombre, edad) VALUES( " + param.Dni.ToString() + ",'" + param.Apellido + 
                "', '" + param.Nombre + "'," + param.Edad.ToString() + ") INSERT INTO dbo.CirujanoRol (idCirujano, idRol) VALUES(" 
                + param.Dni.ToString() + ", "+ ((int)param.Rol).ToString() + ") ";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public bool AgregarRolCirujano(Cirujano param, ERol rol)
        {
            bool rta = true;

            try
            {

                string sql = "INSERT INTO dbo.PacientePatologia (IdCirujano, IdRol VALUES(" + param.Dni.ToString() + ","
                              + ((int)rol).ToString() + ")";

                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
        #endregion

        #region Update

        public bool ModificarCirujano(Cirujano param)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@dni", param.Dni);
                comando.Parameters.AddWithValue("@apellido", param.Apellido);
                comando.Parameters.AddWithValue("@nombre", param.Nombre);
                comando.Parameters.AddWithValue("@edad", param.Edad);

                string sql = "UPDATE dbo.Cirujano ";
                sql += "SET apellido = @apellido, nombre = @nombre, edad = @edad ";
                sql += "WHERE dni = @dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
        public bool ModificarPaciente(Paciente param)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@dni", param.Dni);
                comando.Parameters.AddWithValue("@apellido", param.Apellido);
                comando.Parameters.AddWithValue("@nombre", param.Nombre);
                comando.Parameters.AddWithValue("@edad", param.Edad);

                string sql = "UPDATE dbo.Paciente ";
                sql += "SET apellido = @apellido, nombre = @nombre, edad = @edad ";
                sql += "WHERE dni = @dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Delete
        public bool EliminarPaciente(double dni)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@id", dni);

                string sql = "DELETE FROM dbo.Paciente ";
                sql += "WHERE dni = @dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}

