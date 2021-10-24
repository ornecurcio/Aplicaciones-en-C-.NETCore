using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cirujano:Persona
    {
        private ERol rol;

        public ERol Patologia
        {
            get
            {
                return this.rol;
            }
            set
            {
                this.rol = value;
            }
        }

        public Cirujano(string nombre, string apellido, double dni, ERol rol)
                        : base(nombre, apellido, dni)
        {
            this.rol = rol;
        }
    }
}
