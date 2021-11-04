using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        //private EPatologia patologia;
        private List<EPatologia> patologias; 

        public List<EPatologia> Patologia
        {
            get
            {
                return this.patologias; 
            }
            set
            {
                this.patologias = value; 
            }
        }

        public Paciente():this("sin nombre", "sin apellido", 0, new List<EPatologia>())
        { }
        public Paciente(string nombre, string apellido, double dni, List<EPatologia> patologia)
                        :base(nombre, apellido, dni)
        {
            this.patologias = patologia; 
        }
        public static bool operator ==(Paciente a, Paciente b)
        {
            if(a is not null && b is not null && a.Dni == b.Dni)
            {
                return true; 
            }
            return false; 
        }
        public static bool operator !=(Paciente a, Paciente b)
        {
            return !(a == b); 
        }

        // sobrecarga de == paciente en dni. 
        public override string ToString()
        {
            return this.Apellido + ", " + this.Nombre + ". " + this.Dni;
        }
    }
}
