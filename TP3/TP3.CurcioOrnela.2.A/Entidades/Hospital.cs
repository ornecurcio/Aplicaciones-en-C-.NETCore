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
        private static Dictionary<EPatologia, EProcedimiento> procedimientos;

        static Hospital()
        {
            pacientes = new List<Paciente>();
            cirujanos = new List<Cirujano>();
            procedimientos = new Dictionary<EPatologia, EProcedimiento>();

            pacientes.Add(new Paciente("Lucas", "Rodriguez", 35699823, EPatologia.Columna));
            pacientes.Add(new Paciente("Mauricio", "Cerizza", 36688159, EPatologia.MiembroInferior));
            pacientes.Add(new Paciente("Federico", "Davila", 34195299, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Gaston", "Argibay", 33737302, EPatologia.Columna));
            pacientes.Add(new Paciente("Dario", "Cuda", 23060221, EPatologia.Pelvis));
            pacientes.Add(new Paciente("Maximiliano", "Neiner", 25974068, EPatologia.Pelvis));
            pacientes.Add(new Paciente("Marcos", "Araya", 16123988, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Florencia", "Cuda", 38165629, EPatologia.MiembroInferior));
            pacientes.Add(new Paciente("Octavio", "Villegas", 25524076, EPatologia.Pelvis));
            pacientes.Add(new Paciente("Mauricio", "Davila", 28056659, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Marcos", "Russo", 24271133, EPatologia.MiembroSuperior));
            pacientes.Add(new Paciente("Martin", "Isusi", 36155955, EPatologia.MiembroInferior));

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

            procedimientos.Add(EPatologia.Columna, EProcedimiento.RAFI);
            procedimientos.Add(EPatologia.Columna, EProcedimiento.Artrodecis);
            procedimientos.Add(EPatologia.Columna, EProcedimiento.Osteotomia);
            procedimientos.Add(EPatologia.Columna, EProcedimiento.Yeso);
            procedimientos.Add(EPatologia.Pelvis, EProcedimiento.Osteotomia);
            procedimientos.Add(EPatologia.Pelvis, EProcedimiento.Artrodecis);
            procedimientos.Add(EPatologia.Pelvis, EProcedimiento.Yeso);
            procedimientos.Add(EPatologia.MiembroInferior, EProcedimiento.RAFI);
            procedimientos.Add(EPatologia.MiembroInferior, EProcedimiento.Artrodecis);
            procedimientos.Add(EPatologia.MiembroInferior, EProcedimiento.Osteotomia);
            procedimientos.Add(EPatologia.MiembroInferior, EProcedimiento.ReduccionCerrada);
            procedimientos.Add(EPatologia.MiembroInferior, EProcedimiento.Yeso); 
            procedimientos.Add(EPatologia.MiembroSuperior, EProcedimiento.RAFI);
            procedimientos.Add(EPatologia.MiembroSuperior, EProcedimiento.Artrodecis);
            procedimientos.Add(EPatologia.MiembroSuperior, EProcedimiento.Osteotomia);
            procedimientos.Add(EPatologia.MiembroSuperior, EProcedimiento.ReduccionCerrada);
            procedimientos.Add(EPatologia.MiembroSuperior, EProcedimiento.Yeso);

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
            // if(aux!=listaPaciente)
            //listaPaciente.Add(aux)
        }
        //public static void CargarProcedimientos()
        //{ 
            
        //}
        //public static bool operator ==(Hospital a, Paciente b)
        //{
        //    if (a is not null && b is not null)
        //    {
        //        foreach (Paciente item in a.Pacientes)
        //        {

        //        }
        //    }
        //    return false;
        //}

    }
}
