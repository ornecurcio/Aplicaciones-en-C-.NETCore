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

        public ERol Rol
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
        public static bool operator ==(Cirujano a, Cirujano b)
        {
            if (a is not null && b is not null && a.Dni == b.Dni && a.Rol==b.Rol)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cirujano a, Cirujano b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return this.Apellido +", "+this.Nombre + ". "+this.Rol;
        }
    }
}
