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
    }
}
