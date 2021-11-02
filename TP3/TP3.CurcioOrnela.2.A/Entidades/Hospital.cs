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

            string ruta = Serializacion.GenerarRuta("Pacientes.json");
            //Serializacion.SerializarAJason(ruta, pacientes);
            //ruta = Serializacion.GenerarRuta("Cirujanos.json");
            //Serializacion.SerializarAJason(ruta, cirujanos);
            //ruta = Serializacion.GenerarRuta("Cirugias.json");
            //Serializacion.SerializarAJason(ruta, cirugias);
            //string rutaAlt = Environment.CurrentDirectory;
            //string ruta= rutaAlt + ""
            pacientes = Serializacion.DeserealizarDesdeJson<List<Paciente>>(ruta);
            ruta = Serializacion.GenerarRuta("Cirujanos.json");
            cirujanos = Serializacion.DeserealizarDesdeJson<List<Cirujano>>(ruta);
            ruta = Serializacion.GenerarRuta("Cirugias.json");
            cirugias = Serializacion.DeserealizarDesdeJson<List<Cirugia>>(ruta); 
            //pacientes=pacien; 
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
    }
}
