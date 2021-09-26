using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
   public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas };
        #region Atributo
        ETipo tipo;
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) 
                     :this(marca, chasis, color, ETipo.CuatroPuertas)
        {
            this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor instanciando todos los parametros
        /// </summary>
        /// <param name="marca">la marca del sedan</param>
        /// <param name="chasis">el chasis del sedan</param>
        /// <param name="color">el color del sedan</param>
        /// <param name="tipo">el tipo de sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
                            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }
        #endregion
        #region Propiedad
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Muestra los datos del sedan en un string
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.Mostrar()} TIPO : {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
