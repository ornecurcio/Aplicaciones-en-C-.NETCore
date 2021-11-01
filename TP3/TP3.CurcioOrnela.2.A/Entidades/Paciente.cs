using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private EPatologia patologia;

        public EPatologia Patologia
        {
            get
            {
                return this.patologia; 
            }
            set
            {
                this.patologia = value; 
            }
        }

        public Paciente(string nombre, string apellido, double dni, EPatologia patologia)
                        :base(nombre, apellido, dni)
        {
            this.patologia = patologia; 
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
