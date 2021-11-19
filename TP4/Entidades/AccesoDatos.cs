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
            // CREO UN OBJETO SQLCONECTION
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
                        EPatologia aux = (EPatologia)Enum.Parse(typeof(EPatologia), lector[6].ToString());
                        lista[id].Patologia.Add(aux);
                    }
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Cirujano INNER JOIN dbo.CirujanoRol ON Cirujano.dni = CirujanoRol.idCirujano " +
                                       "INNER JOIN Rol ON CirujanoRol.IdRol = Rol.IdRol " +
                                       "ORDER BY Dni Asc"; 
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                        Cirujano item = new Cirujano();
                        item.Dni = double.Parse(lector["Dni"].ToString());
                        item.Apellido = lector["Apellido"].ToString();
                        item.Nombre = lector["Nombre"].ToString();
                        item.Edad = lector.GetInt32("Edad");
                        item.Rol = (ERol)Enum.Parse(typeof(ERol), lector["IdRol"].ToString());
                        lista.Add(item);
                    
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
                comando.CommandText = "SELECT * FROM Cirujano INNER JOIN dbo.CirujanoRol ON Cirujano.dni = CirujanoRol.idCirujano " +
                                       "INNER JOIN Rol ON CirujanoRol.IdRol = Rol.IdRol " +
                                       "ORDER BY Dni Asc";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cirujano item = new Cirujano();
                    item.Dni = double.Parse(lector["Dni"].ToString());
                    item.Apellido = lector["Apellido"].ToString();
                    item.Nombre = lector["Nombre"].ToString();
                    item.Edad = lector.GetInt32("Edad");
                    item.Rol = (ERol)Enum.Parse(typeof(ERol), lector["IdRol"].ToString());
                    lista.Add(item);

                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        //public List<Paciente> ObtenerListaPlaneta()
        //{
        //    List<Paciente> lista = new List<Paciente>();

        //    try
        //    {
        //        comando = new SqlCommand();

        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = "SELECT * FROM dbo.planetas";
        //        comando.Connection = conexion;

        //        conexion.Open();

        //        lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            Paciente item = new Paciente();

        //            // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
        //            item.Dni = (int)lector[1];
        //            item.Apellido = lector[2].ToString();
        //            item.Nombre = lector[3].ToString();
        //            item.Edad = lector.GetInt32(3);
        //            EPatologia aux = (EPatologia)Enum.Parse(typeof(EPatologia), lector[4].ToString());
        //            item.Patologia.Add(aux); 

        //            lista.Add(item);
        //        }

        //        lector.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //        {
        //            conexion.Close();
        //        }
        //    }

        //    return lista;
        //}


        #endregion

        #region Insert

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
            catch (Exception e)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
                //comando.Parameters.AddWithValue("@gravedad", param.gravedad);

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
            catch (InvalidCastException)
            {
                rta = false;
            }
            catch (System.IO.IOException)
            {
                rta = false;
            }
            catch (ObjectDisposedException)
            {
                rta = false;
            }
            catch (InvalidOperationException)
            {
                rta = false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                rta = false;
            }
            catch (Exception e)
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

        public bool EliminarPlaneta(double dni)
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

