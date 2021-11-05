using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Hospital
    {
        private static List<Paciente> pacientes;
        private static List<Cirujano> cirujanos;
        private static List<Cirugia> cirugias;
        private static Estadistica estadistica; 
        
        static Hospital()
        {
            pacientes = new List<Paciente>();
            cirujanos = new List<Cirujano>();
            cirugias = new List<Cirugia>();
            estadistica = new Estadistica();

            string ruta = Serializacion.GenerarRuta("Pacientes.json");
            //Serializacion.SerializarAJason(ruta, pacientes);
            //ruta = Serializacion.GenerarRuta("Cirujanos.json");
            //Serializacion.SerializarAJason(ruta, cirujanos);
            //ruta = Serializacion.GenerarRuta("Cirugias.json");
            //Serializacion.SerializarAJason(ruta, cirugias);
            //string rutaAlt = Environment.CurrentDirectory;

            pacientes = Serializacion.DeserealizarDesdeJson<List<Paciente>>(ruta);
            ruta = Serializacion.GenerarRuta("Cirujanos.json");
            cirujanos = Serializacion.DeserealizarDesdeJson<List<Cirujano>>(ruta);
            ruta = Serializacion.GenerarRuta("Cirugias.json");
            cirugias = Serializacion.DeserealizarDesdeJson<List<Cirugia>>(ruta);
            Hospital.ActualizarEstadistica(cirugias, cirujanos); 

        }
        public static List<Paciente> Pacientes
        {
            get
            {
                return pacientes; 
            }
            set
            {
                if(value is not null)
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
        public static List<Cirugia> Cirugias
        {
            get
            {
                return cirugias;
            }
            set
            {
                if (value is not null)
                {
                    cirugias = value;
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
                if(value is not null)
                {
                    estadistica = value; 
                }
            }
        }
        public static void CargarCirugia(Cirugia aux)
        {
            cirugias.Add(aux);
            estadistica.ActualizarPatologia(aux.Patologia);
            estadistica.ActualizarRol(aux.Cirujano.Rol);
            string ruta = Serializacion.GenerarRuta("Cirugias.json");
            Serializacion.SerializarAJason(ruta, cirugias);
        }
        public static bool CargarCirujanos(Cirujano aux)
        {
            foreach (Cirujano item in cirujanos)
            {
                if (aux != item)
                {
                    cirujanos.Add(aux);
                    string ruta = Serializacion.GenerarRuta("Cirujanos.json");
                    Serializacion.SerializarAJason(ruta, cirujanos);
                    return true;
                }
            }
            return false;
        }
        public static bool ActualizarPaciente(Paciente aux)
        {
            foreach (Paciente item in Pacientes)
            {
                if (aux == item)
                {
                    Pacientes.Remove(item);
                    Pacientes.Add(aux); 
                    string ruta = Serializacion.GenerarRuta("Pacientes.json");
                    Serializacion.SerializarAJason(ruta, pacientes);
                    return true;
                }
            }
            return false;
        }
        public static bool CargarPacientes(Paciente aux)
        {
            foreach (Paciente item in Pacientes)
            {
                if(aux!=item)
                {
                    Pacientes.Add(aux);
                    string ruta = Serializacion.GenerarRuta("Pacientes.json");
                    Serializacion.SerializarAJason(ruta, pacientes);
                    return true;
                }
            }
            return false; 
        }
        public static void ActualizarEstadistica(List<Cirugia>cirugias, List<Cirujano>cirujanos)
        {
            foreach (Cirugia item in cirugias)
            {
                Hospital.Estadistica.ActualizarPatologia(item.Patologia);
                item.Cirujano.Estadistica.ActualizarPatologia(item.Patologia);
                //Hospital.Estadistica.ActualizarProcedimiento(item.Procedimiento);
                //item.Cirujano.Estadistica.ActualizarProcedimiento(item.Procedimiento); 
            }
        }
        public static List<Cirugia> CirugiasXPatologia(EPatologia patologia)
        {
            List<Cirugia> cirugiasXPatologia = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugias)
            {
                if(item.Patologia == patologia)
                {
                    cirugiasXPatologia.Add(item); 
                }
            }
            return cirugiasXPatologia; 
        }
        public static List<Cirugia> CirugiasXProcedimiento(EProcedimiento procedimiento)
        {
            List<Cirugia> cirugiasXProcedimiento = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugias)
            {
                if (item.Procedimiento == procedimiento)
                {
                    cirugiasXProcedimiento.Add(item);
                }
            }
            return cirugiasXProcedimiento;
        }
        public static List<Cirugia> CirugiasXCirujano(Cirujano cirujano)
        {
            List<Cirugia> cirugiasXCirujano = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugias)
            {
                if (item.Cirujano == cirujano)
                {
                    cirugiasXCirujano.Add(item);
                }
            }
            return cirugiasXCirujano;
        }
        public static List<Cirugia> CirugiasXProcedimientoYCirujano(EProcedimiento procedimiento, Cirujano cirujano)
        {
            List<Cirugia> cirugiasXProcedimientoYCirujano = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugias)
            {
                if (item.Procedimiento == procedimiento && item.Cirujano==cirujano)
                {
                    cirugiasXProcedimientoYCirujano.Add(item);
                }
            }
            return cirugiasXProcedimientoYCirujano;
        }
        public static List<Cirugia> CirugiasXPatologiaYCirujano(EPatologia patologia, Cirujano cirujano)
        {
            List<Cirugia> cirugiasXPatologiaYCirujano = new List<Cirugia>();
            foreach (Cirugia item in Hospital.cirugias)
            {
                if (item.Patologia == patologia && item.Cirujano == cirujano)
                {
                    cirugiasXPatologiaYCirujano.Add(item);
                }
            }
            return cirugiasXPatologiaYCirujano;
        }
    }
}
