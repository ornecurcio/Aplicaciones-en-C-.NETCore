using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivo
    {
        /// <summary>
        /// Genera un path donde se puede guardar un archivo
        /// </summary>
        /// <param name="titulo">que tiene el archivo</param>
        /// <returns>path donde se encuentra el archivo</returns>
        public static string GenerarRuta(string titulo)
        {
            try
            {
                string rutaAlt = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(rutaAlt, titulo);
                return rutaArchivo;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo generar la ruta", ex);
            }
        }

        public static void EscribirNuevoTxt(string ruta, string data)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta, false))
                {
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void EscribirAgregarTxt(string ruta, string data)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta, true))
                {
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
