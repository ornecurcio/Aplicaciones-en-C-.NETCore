using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv:Vehiculo
    {
        #region Constructor
        /// <summary>
        /// Constructor de la suv
        /// </summary>
        /// <param name="marca">marca de la suv</param>
        /// <param name="chasis">chasis de la suv</param>
        /// <param name="color">color de la suv</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion
        #region Propiedad
        /// <summary>
        /// ReadOnly. SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion
        #region Metodo
        /// <summary>
        /// Muestra los datos de la SUV en un string
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar()); 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
