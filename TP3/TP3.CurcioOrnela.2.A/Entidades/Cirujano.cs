using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cirujano:Persona //, ICirugia
    {
        private ERol rol;
        private Estadistica estadistica;
        //private bool realizoCirugia; 
        public Cirujano(string nombre, string apellido, double dni, ERol rol, Estadistica estadistica) //, bool realizoCirugia)
                       : base(nombre, apellido, dni)
        {
            this.rol = rol;
            this.estadistica = estadistica;
            //this.realizoCirugia = realizoCirugia; 
        }
        //public bool RealizoCirugia
        //{
        //    get
        //    {
        //        return this.realizoCirugia; 
        //    }
        //    set
        //    {
        //        this.realizoCirugia = value;
        //    }
        //}

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
        public Estadistica Estadistica
        {
            get
            {
                return this.estadistica; 
            }
            set
            {
                if(value is not null)
                {
                    this.estadistica = value; 
                }
            }
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
        public bool PrepararCirugia()
        {
            if (this is not null)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
