using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ExceptionSerializacion:Exception
    {
        private static string mensajeError;

        static ExceptionSerializacion()
        {
            mensajeError = "Error en la serializacion";
        }
      
        public ExceptionSerializacion(): this(ExceptionSerializacion.mensajeError)
        {

        }
        public ExceptionSerializacion(string mensaje): base(mensaje)
        {

        }
           
        public ExceptionSerializacion(Exception innerException): base(ExceptionSerializacion.mensajeError, innerException)
        {

        }
    }
}
