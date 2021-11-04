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
            List<EPatologia>  patologias = new List<EPatologia>();
            patologias.Add(EPatologia.Columna);
            patologias.Add(EPatologia.MiembroSuperior); 
            pacientes.Add(new Paciente("Lucas", "Rodriguez", 35699823, patologias));
            patologias.Remove(EPatologia.Columna);  
            pacientes.Add(new Paciente("Mauricio", "Cerizza", 36688159, patologias));
            patologias.Remove(EPatologia.MiembroSuperior);
            patologias.Add(EPatologia.MiembroInferior); 
            pacientes.Add(new Paciente("Federico", "Davila", 34195299, patologias));
            patologias.Remove(EPatologia.MiembroInferior);
            patologias.Add(EPatologia.Columna);
            pacientes.Add(new Paciente("Esteban", "Prieto", 37737302, patologias));
            patologias.Remove(EPatologia.Columna);
            patologias.Add(EPatologia.Pelvis); 
            pacientes.Add(new Paciente("Dario", "Cuda", 23060221, patologias));
            pacientes.Add(new Paciente("Maximiliano", "Neiner", 25974068, patologias));
            patologias.Add(EPatologia.MiembroInferior);
            patologias.Remove(EPatologia.Pelvis); 
            pacientes.Add(new Paciente("Marcos", "Araya", 16123988, patologias));
            pacientes.Add(new Paciente("Florencia", "Cuda", 38165629, patologias));
            patologias.Add(EPatologia.MiembroSuperior);
            pacientes.Add(new Paciente("Octavio", "Villegas", 25524076, patologias));
            pacientes.Add(new Paciente("Mauricio", "Davila", 28056659, patologias));
            patologias.Add(EPatologia.Pelvis);
            pacientes.Add(new Paciente("Marcos", "Russo", 24271133, patologias));
            pacientes.Add(new Paciente("Martin", "Isusi", 36155955, patologias));
            patologias.Remove(EPatologia.MiembroSuperior);
            patologias.Add(EPatologia.Columna);
            pacientes.Add(new Paciente("Escudero", "Yanina", 23159922, patologias));

            cirujanos.Add(new Cirujano("Ornela", "Curcio", 34707599, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Ornela", "Curcio", 34707599, ERol.Ayudante, new Estadistica()));
            cirujanos.Add(new Cirujano("Juan Pablo", "Albarracin", 14237825, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Juan Pablo", "Albarracin", 14237825, ERol.Ayudante, new Estadistica()));
            cirujanos.Add(new Cirujano("Natalia", "Acorintti", 33963306, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Natalia", "Acorintti", 33963306, ERol.Ayudante, new Estadistica()));
            cirujanos.Add(new Cirujano("Juan", "Peralta", 32980534, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Juan", "Peralta", 32980534, ERol.Ayudante, new Estadistica()));
            cirujanos.Add(new Cirujano("Lucia", "Guidali", 33203789, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Lucia", "Guidali", 33203789, ERol.Ayudante, new Estadistica()));
            cirujanos.Add(new Cirujano("Noelia", "Gonzalez", 33203790, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Noelia", "Gonzalez", 33203790, ERol.Ayudante, new Estadistica()));
            cirujanos.Add(new Cirujano("Daniel", "Villena", 22963307, ERol.Cirujano, new Estadistica()));
            cirujanos.Add(new Cirujano("Daniel", "Villena", 22963307, ERol.Ayudante, new Estadistica()));

            cirugias.Add(new Cirugia(pacientes[0], new DateTime(2020, 5, 12), cirujanos[0], EPatologia.Columna, EProcedimiento.Yeso));
            cirugias.Add(new Cirugia(pacientes[1], new DateTime(2020, 12, 24), cirujanos[3], EPatologia.MiembroInferior, EProcedimiento.RAFI));
            cirugias.Add(new Cirugia(pacientes[2], new DateTime(2020, 8, 1), cirujanos[7], EPatologia.MiembroSuperior, EProcedimiento.Osteodesis));
            cirugias.Add(new Cirugia(pacientes[3], new DateTime(2020, 2, 5), cirujanos[0], EPatologia.Columna, EProcedimiento.Artrodecis));
            cirugias.Add(new Cirugia(pacientes[4], new DateTime(2020, 10, 6), cirujanos[6], EPatologia.Pelvis, EProcedimiento.Osteotomia));
            cirugias.Add(new Cirugia(pacientes[5], new DateTime(2020, 11, 17), cirujanos[13], EPatologia.Pelvis, EProcedimiento.Yeso));

            string ruta = Serializacion.GenerarRuta("Pacientes.json");
            Serializacion.SerializarAJason(ruta, pacientes);
            ruta = Serializacion.GenerarRuta("Cirujanos.json");
            Serializacion.SerializarAJason(ruta, cirujanos);
            ruta = Serializacion.GenerarRuta("Cirugias.json");
            Serializacion.SerializarAJason(ruta, cirugias);
            string rutaAlt = Environment.CurrentDirectory;

            //pacientes = Serializacion.DeserealizarDesdeJson<List<Paciente>>(ruta);
            //ruta = Serializacion.GenerarRuta("Cirujanos.json");
            //cirujanos = Serializacion.DeserealizarDesdeJson<List<Cirujano>>(ruta);
            //ruta = Serializacion.GenerarRuta("Cirugias.json");
            //cirugias = Serializacion.DeserealizarDesdeJson<List<Cirugia>>(ruta);

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
