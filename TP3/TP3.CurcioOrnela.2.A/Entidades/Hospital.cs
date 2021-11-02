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

            pacientes.Add(new Paciente("Lucas", "Rodriguez", 35699823, EPatologia.Columna));
            pacientes.Add(new Paciente("Mauricio", "Cerizza", 36688159, EPatologia.MiembroInferior));
            pacientes.Add(new Paciente("Federico", "Davila", 34195299, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Esteban", "Prieto", 37737302, EPatologia.Columna));
            pacientes.Add(new Paciente("Dario", "Cuda", 23060221, EPatologia.Pelvis));
            pacientes.Add(new Paciente("Maximiliano", "Neiner", 25974068, EPatologia.Pelvis));
            pacientes.Add(new Paciente("Marcos", "Araya", 16123988, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Florencia", "Cuda", 38165629, EPatologia.MiembroInferior));
            pacientes.Add(new Paciente("Octavio", "Villegas", 25524076, EPatologia.Pelvis));
            pacientes.Add(new Paciente("Mauricio", "Davila", 28056659, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Marcos", "Russo", 24271133, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Martin", "Isusi", 36155955, EPatologia.MiembroInferior));
            pacientes.Add(new Paciente("Escudero", "Yanina", 23159922, EPatologia.MiembroSuperior));

            cirujanos.Add(new Cirujano("Ornela", "Curcio", 34707599, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Ornela", "Curcio", 34707599, ERol.Ayudante));
            cirujanos.Add(new Cirujano("Juan Pablo", "Albarracin", 14237825, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Juan Pablo", "Albarracin", 14237825, ERol.Ayudante));
            cirujanos.Add(new Cirujano("Natalia", "Acorintti", 33963306, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Natalia", "Acorintti", 33963306, ERol.Ayudante));
            cirujanos.Add(new Cirujano("Juan", "Peralta", 32980534, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Juan", "Peralta", 32980534, ERol.Ayudante));
            cirujanos.Add(new Cirujano("Lucia", "Guidali", 33203789, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Lucia", "Guidali", 33203789, ERol.Ayudante));
            cirujanos.Add(new Cirujano("Noelia", "Gonzalez", 33203790, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Noelia", "Gonzalez", 33203790, ERol.Ayudante));
            cirujanos.Add(new Cirujano("Daniel", "Villena", 22963307, ERol.Cirujano));
            cirujanos.Add(new Cirujano("Daniel", "Villena", 22963307, ERol.Ayudante));

            cirugias.Add(new Cirugia(pacientes[0], new DateTime(2020, 5, 12),cirujanos[0], EPatologia.Columna, EProcedimiento.Yeso));
            cirugias.Add(new Cirugia(pacientes[1], new DateTime(2020, 12, 24),cirujanos[3], EPatologia.MiembroInferior, EProcedimiento.RAFI));
            cirugias.Add(new Cirugia(pacientes[2], new DateTime(2020, 8, 1), cirujanos[7], EPatologia.MiembroSuperior, EProcedimiento.Osteodesis));
            cirugias.Add(new Cirugia(pacientes[3], new DateTime(2020, 2, 5), cirujanos[0], EPatologia.Columna, EProcedimiento.Artrodecis));
            cirugias.Add(new Cirugia(pacientes[4], new DateTime(2020, 10, 6), cirujanos[6], EPatologia.Pelvis, EProcedimiento.Osteotomia));
            cirugias.Add(new Cirugia(pacientes[5], new DateTime(2020, 11, 17), cirujanos[13], EPatologia.Pelvis, EProcedimiento.Yeso));

        }
        public static List<Paciente> Pacientes
        {
            get
            {
                return pacientes; 
            }
        }
        public static List<Cirujano> Cirujanos
        {
            get
            {
                return cirujanos;
            }
        }
        public static List<Cirugia> Cirugias
        {
            get
            {
                return cirugias;
            }
        }
        public static bool CargarCirujanos(Cirujano aux)
        {
            foreach (Cirujano item in cirujanos)
            {
                if (aux != item)
                {
                    cirujanos.Add(aux);
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
                    return true; 
                }
            }
            return false; 
        }
    }
}
