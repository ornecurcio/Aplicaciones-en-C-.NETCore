﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
                            : base(chasis, marca, color)
        {
        }
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
        /// <summary>
        /// Muestra los datos del ciclomotor en un string
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
