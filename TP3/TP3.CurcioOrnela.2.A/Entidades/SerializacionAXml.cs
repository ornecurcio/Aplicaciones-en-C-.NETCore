using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization; 

namespace Entidades
{
    public class SerializacionAXml<T> where T: new()
    {
        public string GenerarRuta(string titulo)
        {
            string rutaAlt = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(rutaAlt, titulo);
            return rutaArchivo;
        }
        //public void SerializarAXmlLista<T>(string ruta, List<T> obj) where T :class
        public static void SerializarAXmlLista(string ruta, T obj) 
        {
            XmlTextWriter xmlWriter = null;
            XmlSerializer serializador = null;
            try
            {
                xmlWriter = new XmlTextWriter(ruta, Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                serializador = new XmlSerializer(typeof(T));
                serializador.Serialize(xmlWriter, obj);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo serializar a Xml",ex);
            }
            finally
            {
                if (xmlWriter != null)
                {
                    xmlWriter.Close();
                }
            }
        }
        /// <summary>
        /// Lee un archivo y lo guarda como dato generico
        /// </summary>
        /// <param name="archivo">Es el nombre del archivo que se va a leer</param>
        /// <param name="datos">Donde se van a almacenar los datos leidos</param>
        /// <returns>True en caso exitoso, de lo contrario lanzara ArchivosException</returns>
        /// 
        //public T DeserealizarXml<T>(string ruta)where T:class
        public static T DeserealizarXml(string ruta) 
        {
            XmlTextReader xmlReader = null;
            XmlSerializer serializador = null;
            try
            {
                xmlReader = new XmlTextReader(ruta);
                serializador = new XmlSerializer(typeof(T));
                T objetoDesealizado = (T)serializador.Deserialize(xmlReader);
                return objetoDesealizado;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo deserealizar Xml",ex);
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
            }
        }
    }
}
