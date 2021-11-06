﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms; 

namespace Formulario
{
    public interface ICargarCmb
    {
        void CargarCmb<T>(ComboBox d, List<T> lista)
            where T : class
        {
            d.DataSource = null;
            if (lista.Count > 0)
            {
                d.DataSource = lista;
                //if (typeof(T) == typeof(Cirugia))
                //{
                //    //d.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                       
                //}
            }
        }
    }
}