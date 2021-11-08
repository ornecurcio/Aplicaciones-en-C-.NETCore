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
                throw new SerializacionException(ex);
            }
            finally
            {
                if (xmlWriter != null)
                {
                    xmlWriter.Close();
                }
            }
        }
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
                throw new SerializacionException(ex);
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
