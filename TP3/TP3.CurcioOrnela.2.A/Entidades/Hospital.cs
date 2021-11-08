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
            try
            {
                pacientes = new List<Paciente>();
                cirujanos = new List<Cirujano>();
                cirugias = new List<Cirugia>();
                estadistica = new Estadistica();

                string ruta = SerializacionAJason.GenerarRuta("Pacientes.json");
                pacientes = SerializacionAJason.DeserealizarDesdeJson<List<Paciente>>(ruta);
                ruta = SerializacionAJason.GenerarRuta("Cirujanos.json");
                cirujanos = SerializacionAJason.DeserealizarDesdeJson<List<Cirujano>>(ruta);
                ruta = SerializacionAJason.GenerarRuta("Cirugias.json");
                cirugias = SerializacionAJason.DeserealizarDesdeJson<List<Cirugia>>(ruta);
                Hospital.ActualizarEstadistica(cirugias);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar Hospital", ex);
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
                if (value is not null)
                {
                    estadistica = value;
                }
            }
        }

        public static void SerializarPacientes()
        {
            string ruta = SerializacionAJason.GenerarRuta("Pacientes.json");
            SerializacionAJason.SerializarAJason(ruta, pacientes);
        }
        public static void SerializarCirugias()
        {
            string ruta = SerializacionAJason.GenerarRuta("Cirugias.json");
            SerializacionAJason.SerializarAJason(ruta, cirugias);
        }
        public static void SerializarCirujanos()
        {
            string ruta = SerializacionAJason.GenerarRuta("Cirujanos.json");
            SerializacionAJason.SerializarAJason(ruta, cirujanos);
        } 
        
        public static bool CargarCirugia(Cirugia aux)
        {
            try
            {
                if (aux is not null)
                {
                    cirugias.Add(aux);
                    estadistica.ActualizarPatologia(aux.Patologia);
                    estadistica.ActualizarProcedimiento(aux.Procedimiento);
                    SerializarCirugias();
                    SerializarCirujanos();
                    return true; 
                }
                return false; 
            }
            catch(Exception ex)
            {
                throw new Exception("Fallo en cargar cirugia", ex); 
            }
        }
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
                SerializarCirujanos();
                return true; 
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
                    SerializarPacientes(); 
                    return true;
                }
            }
            return false;
        }
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
                SerializarPacientes();
                return true;
            }
            return false;
        }
        public static void ActualizarEstadistica(List<Cirugia>cirugias)
        {
            foreach (Cirugia item in cirugias)
            {
                Hospital.Estadistica.ActualizarPatologia(item.Patologia);
                Hospital.Estadistica.ActualizarProcedimiento(item.Procedimiento);
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
