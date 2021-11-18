using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructor
        /// <summary>
        /// Constructor de un ciclomotor
        /// </summary>
        /// <param name="marca">marca del ciclomotor</param>
        /// <param name="chasis">chasis del ciclomotor</param>
        /// <param name="color">color del ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
                            : base(chasis, marca, color)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos del ciclomotor en un string
        /// </summary>
        /// <returns>un string con los datos del ciclomotor</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
