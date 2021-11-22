using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Hospital
    {
        #region Atributos
        private static List<Paciente> pacientes;
        private static List<Cirujano> cirujanos;
        private static List<Cirugia> cirugiasPendientes;
        private static List<Cirugia> cirugiasRealizadas;
        private static Estadistica estadistica;
        private static CancellationTokenSource cts;
        private static AccesoDatos datos; 

        #endregion

        #region Constructor
        static Hospital()
        {
            try
            {
                pacientes = new List<Paciente>();
                cirujanos = new List<Cirujano>();
                cirugiasPendientes = new List<Cirugia>();
                cirugiasRealizadas = new List<Cirugia>(); 
                estadistica = new Estadistica();
                cts = new CancellationTokenSource();
                datos = new AccesoDatos();

                pacientes = datos.ObtenerListaPacientes();
                cirujanos = datos.ObtenerListaCirujanos();
                cirugiasRealizadas = datos.ObtenerListaCirugias(); 
                //string ruta = Archivo.GenerarRuta("Pacientes.json");
                //pacientes = SerializacionAJason.DeserealizarDesdeJson<List<Paciente>>(ruta);
                //foreach (Paciente item in pacientes)
                //{
                //    Random rdn = new Random();
                //    int numero = rdn.Next(1, 4); 
                //    if(item.Patologia.Count==0)
                //    {
                //        datos.AgregarPatologiaPaciente(item, (EPatologia)Enum.Parse(typeof(EPatologia),numero.ToString()));
                //    }
                //}
                //ruta = Archivo.GenerarRuta("Cirujanos.json");
                //cirujanos = SerializacionAJason.DeserealizarDesdeJson<List<Cirujano>>(ruta);
                string ruta = Archivo.GenerarRuta("Cirugias.json");
                cirugiasPendientes = SerializacionAJason.DeserealizarDesdeJson<List<Cirugia>>(ruta);
                Hospital.ActualizarEstadistica(cirugiasRealizadas);
                datos.ActualizarEstadisticaHospital(Hospital.Estadistica); 
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar Hospital", ex);
            }
        }
        #endregion

        #region Propiedades
        public static CancellationTokenSource Cts
        {

            get
            {
                if (cts is null || cts.IsCancellationRequested)
                {
                    cts = new CancellationTokenSource();
                }

                return cts;
            }

        }
        public static List<Paciente> Pacientes
        {
            get
            {
                return pacientes;
            }
            set
            {
                if (value is not null)
                {
                    pacientes = value;
                }
            }
        }
        public static List<Cirujano> Cirujanos
        {
            get
            {
                return cirujanos;
            }
            set
            {
                if (value is not null)
                {
                    cirujanos = value;
                }
            }
        }
        public static List<Cirugia> CirugiasPendientes
        {
            get
            {
                return cirugiasPendientes;
            }
            set
            {
                if (value is not null)
                {
                    cirugiasPendientes = value;
                }
            }
        }
        public static List<Cirugia> CirugiasRealizadas
        {
            get
            {
                return cirugiasRealizadas;
            }
            set
            {
                if (value is not null)
                {
                    cirugiasRealizadas = value;
                }
            }
        }
        public static Estadistica Estadistica
        {
            get
            {
                return estadistica;
            }
            set
            {
                if (value is not null)
                {
                    estadistica = value;
                }
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Serializa a Archivo Json una lista de pacientes
        /// </summary>
        public static void SerializarPacientes()
        {
            string ruta = Archivo.GenerarRuta("Pacientes.json");
            SerializacionAJason.SerializarAJason(ruta, pacientes);
        }
        /// <summary>
        /// Serializa a Archivo Json una lista de cirugias
        /// </summary>
        public static void SerializarCirugias()
        {
            string ruta = Archivo.GenerarRuta("Cirugias.json");
            SerializacionAJason.SerializarAJason(ruta, cirugiasPendientes);
        }
        /// <summary>
        /// Serializa a Archivo Json una lista de cirujanos 
        /// </summary>
        public static void SerializarCirujanos()
        {
            string ruta = Archivo.GenerarRuta("Cirujanos.json");
            SerializacionAJason.SerializarAJason(ruta, cirujanos);
        } 
        /// <summary>
        /// Carga una nueva cirugia a la lista de cirugias y actualiza la estadistica del cirujano y el htal
        /// </summary>
        /// <param name="aux"> cirugia a ser agregada</param>
        /// <returns>TRUE si se cargo con exito</returns>
        public static bool CargarCirugiaPendiente(Cirugia aux)
        {
            try
            {
                if (aux is not null)
                {
                    cirugiasPendientes.Add(aux);
                    SerializarCirugias();
                    return true; 
                }
                return false; 
            }
            catch(Exception ex)
            {
                throw new Exception("Fallo en cargar cirugia", ex); 
            }
        }

        /// <summary>
        /// Agrega un nuevo cirujano a la lista si el mismo no existe 
        /// </summary>
        /// <param name="aux"> cirujano a agregar</param>
        /// <returns>TRUE si se cargo con exito</returns>
        public static bool CargarCirujanos(Cirujano aux)
        {
            if (aux is not null)
            {
                foreach (Cirujano item in cirujanos)
                {
                    if (item==aux)
                    {
                        return false;
                    }
                }
                cirujanos.Add(aux);
                datos.AgregarCirujano(aux); 
                SerializarCirujanos();
                return true; 
            }
            return false;
        }
        /// <summary>
        /// Actualiza los datos de un paciente
        /// </summary>
        /// <param name="aux">paciente a actualizar</param>
        /// <returns>TRUE si pudo modificarlo</returns>
        public static bool ActualizarPacientePatologia(Paciente aux, EPatologia patologia)
        {
            if (aux is not null)
            {
                datos.AgregarPatologiaPaciente(aux, patologia);
                return true; 
            }
            return false;
        }
        /// <summary>
        /// Agrega un paciente a la lista si el paciente no existe
        /// </summary>
        /// <param name="aux">paciente a agregar</param>
        /// <returns></returns>
        public static bool CargarPacientes(Paciente aux)
        {
            if (aux is not null)
            {
                foreach (Paciente item in Pacientes)
                {
                    if (aux == item)
                    {
                        return false;
                    }
                }
                Pacientes.Add(aux);
                datos.AgregarPaciente(aux);
                foreach (EPatologia item in aux.Patologia)
                {
                    datos.AgregarPatologiaPaciente(aux, item); 
                }
                SerializarPacientes();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Actualiza la estadistica del hospital al iniciarse el programa
        /// </summary>
        /// <param name="cirugias"> listado de cirugias</param>
        public static void ActualizarEstadistica(List<Cirugia>cirugias)
        {
            foreach (Cirugia item in cirugias)
            {
                Hospital.Estadistica.ActualizarPatologia(item.Patologia);
                Hospital.Estadistica.ActualizarProcedimiento(item.Procedimiento);
                //item.Cirujano.Estadistica.ActualizarPatologia(item.Patologia);
                //item.Cirujano.Estadistica.ActualizarProcedimiento(item.Procedimiento); 
            }
        }
        /// <summary>
        /// Genera una lista de cirugias por el patologia operada
        /// </summary>
        /// <param name="patologia">tipo de patologia a filtrar</param>
        /// <returns>Lista de cirugias con esa patologia</returns>
        public static List<Cirugia> CirugiasXPatologia(EPatologia patologia)
        {
            List<Cirugia> cirugiasXPatologia = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugiasRealizadas)
            {
                if(item.Patologia == patologia)
                {
                    cirugiasXPatologia.Add(item); 
                }
            }
            return cirugiasXPatologia; 
        }
        /// <summary>
        /// Genera una lista de cirugias por procedimiento echo
        /// </summary>
        /// <param name="procedimiento">tipo de procedimiento a filtrar</param>
        /// <returns>Lista de cirugias con el procedimiento echo </returns>
        public static List<Cirugia> CirugiasXProcedimiento(EProcedimiento procedimiento)
        {
            List<Cirugia> cirugiasXProcedimiento = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugiasRealizadas)
            {
                if (item.Procedimiento == procedimiento)
                {
                    cirugiasXProcedimiento.Add(item);
                }
            }
            return cirugiasXProcedimiento;
        }
        /// <summary>
        /// Genera una lista de cirugias por cirujano
        /// </summary>
        /// <param name="cirujano">cirujano que realizo la cirugia</param>
        /// <returns>Lista de cirugias con ese cirujano</returns>
        public static List<Cirugia> CirugiasXCirujano(Cirujano cirujano)
        {
            List<Cirugia> cirugiasXCirujano = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugiasRealizadas)
            {
                if (item.Cirujano == cirujano)
                {
                    cirugiasXCirujano.Add(item);
                }
            }
            return cirugiasXCirujano;
        }
        /// <summary>
        /// Genera lista de cirigia por cirujano y procedimiento
        /// </summary>
        /// <param name="procedimiento">Tipo de cirugia echa</param>
        /// <param name="cirujano">quien hizo la cirugia</param>
        /// <returns>lista filtrada</returns>
        public static List<Cirugia> CirugiasXProcedimientoYCirujano(EProcedimiento procedimiento, Cirujano cirujano)
        {
            List<Cirugia> cirugiasXProcedimientoYCirujano = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugiasRealizadas)
            {
                if (item.Procedimiento == procedimiento && item.Cirujano==cirujano)
                {
                    cirugiasXProcedimientoYCirujano.Add(item);
                }
            }
            return cirugiasXProcedimientoYCirujano;
        }
        /// <summary>
        /// Genera lista de cirugia por patologia y cirujano
        /// </summary>
        /// <param name="patologia">la patologia a filtrar </param>
        /// <param name="cirujano">cirujano que realizo</param>
        /// <returns>Lista filtrada</returns>
        public static List<Cirugia> CirugiasXPatologiaYCirujano(EPatologia patologia, Cirujano cirujano)
        {
            List<Cirugia> cirugiasXPatologiaYCirujano = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugiasRealizadas)
            {
                if (item.Patologia == patologia && item.Cirujano == cirujano)
                {
                    cirugiasXPatologiaYCirujano.Add(item);
                }
            }
            return cirugiasXPatologiaYCirujano;
        }
        public static string CargarInfoPacientes()
        {
            float cantidadPacientesMayoresDeEdad = 0;
            float porcentaje;
            foreach (Paciente item in Hospital.Pacientes)
            {
                if (item.Edad > 18)
                    cantidadPacientesMayoresDeEdad++;
            }

            porcentaje = cantidadPacientesMayoresDeEdad / Hospital.Pacientes.Count;

            return $"Pacientes mayores de edad: {Math.Round(porcentaje, 2) * 100}% " +
                   $"(Cantidad de pacientes mayores de edad: {cantidadPacientesMayoresDeEdad} de {Hospital.Pacientes.Count}) \n\n";
        }
        public static string PocentajeCirugiasCadaMedico()
        {
            Dictionary<Cirujano, int> contador = new Dictionary<Cirujano, int>();

            foreach (Cirujano cirujano in Hospital.Cirujanos)
            {
                int cantidad = 0;
                foreach (Cirugia item in Hospital.CirugiasRealizadas)
                {
                    if (cirujano == item.Cirujano)
                    {
                        cantidad++;
                    }
                }
                contador.Add(cirujano, cantidad);
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"------------------------Porcentaje de Cirugias por Medico------------------------"); 
            foreach (KeyValuePair<Cirujano, int> item in contador)
            {
                float porcentaje = ((float)item.Value / Hospital.CirugiasRealizadas.Count) * 100;
                stringBuilder.AppendLine($"{item.Key.ToString()} realizo {Math.Round(porcentaje, 2)}% (Cantidad: {item.Value} de {Hospital.CirugiasRealizadas.Count})");
            }
            return stringBuilder.ToString();
        }
        public static string CargarInfoCirujanos()
        {
            float cantCirujanos = 0;
            foreach (Cirujano item in Hospital.Cirujanos)
            {
                if (item.Rol == ERol.Ayudante)
                {
                    cantCirujanos++;
                }
            }
            float porcentaje = cantCirujanos / Hospital.Cirujanos.Count;

            return $"Los ayudantes representan el {Math.Round(porcentaje, 2) * 100}% de los medicos " +
                   $"(Cantidad ayudantes: {cantCirujanos} de {Hospital.Cirujanos.Count}) \n\n";
        }
        public static string CargarPatologiaPrevalente()
        {
            EPatologia aux = Hospital.Estadistica.PatologiaPrevalente();
            int auxCant = Hospital.Estadistica.CantPatologiaPrevalente();

            float porcentaje = (float)auxCant / Hospital.CirugiasRealizadas.Count;

            return $"La patologia mas operada es {aux} con un porcentaje de {Math.Round(porcentaje, 2) * 100}% " +
                   $"(Cantidad {aux}: {auxCant} de {Hospital.CirugiasRealizadas.Count}) \n\n";
        }
        public static string CargarProcedimientoPrevalente()
        {
            EProcedimiento aux = Hospital.Estadistica.ProcedimientoPrevalente();
            int auxCant = Hospital.Estadistica.CantProcedimientoPrevalente();

            float porcentaje = (float)auxCant / Hospital.CirugiasRealizadas.Count;

            return $"El procedimiento mas realizado es {aux} con un porcentaje de {Math.Round(porcentaje, 2) * 100}% " +
                   $"(Cantidad {aux}: {auxCant} de {Hospital.CirugiasRealizadas.Count}) \n\n";
        }
        #endregion
    }
}
