using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        };
        public enum ETamanio
        {
            Chico, Mediano, Grande
        };
        #region Atributos
        private string chasis;
        private EMarca marca;
        private ConsoleColor color;
        #endregion
        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de un vehiculo
        /// </summary>
        /// <param name="chasis">el chasis del vehiculo</param>
        /// <param name="marca">la marca del vehiculo</param>
        /// <param name="color">el color del vehiculo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// Sobrecarga, casteo explicito a string
        /// </summary>
        /// <param name="p">vehiculo con datos a castear</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            if (!(p is null))
            {
                sb.AppendLine($"{p.GetType().Name.ToUpper()}"); 
                sb.AppendLine($"CHASIS: {p.chasis}");
                sb.AppendLine($"MARCA : {p.marca}");
                sb.AppendLine($"COLOR : {p.color}");
                sb.AppendLine("---------------------");
                sb.Append($"TAMAÑO: {p.Tamanio}"); 
            }
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1 is null && v2 is null)
            {
                return true;
            }
            else
            {
                if (!(v1 is null) && !(v2 is null))
                {
                    if (v1.chasis == v2.chasis)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
        public override int GetHashCode()
        {
            return (chasis).GetHashCode();
        }
    }
}
