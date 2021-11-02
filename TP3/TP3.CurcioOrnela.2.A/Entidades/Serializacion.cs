using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json; 

namespace Entidades
{
    public class Serializacion
    {
        public static string GenerarRuta(string titulo)
        {
            //string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rutaAlt = AppDomain.CurrentDomain.BaseDirectory; 
            //string rutaArchivo = Path.Combine(rutaEscritorio, titulo);
            string rutaArchivo = Path.Combine(rutaAlt, titulo);
            return rutaArchivo;
        }
        public static void SerializarAJason<T>(string ruta, T obj) where T : class
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;

            string objetoJson = JsonSerializer.Serialize(obj, jsonSerializerOptions);

            File.WriteAllText(ruta, objetoJson);
        }
        public static T DeserealizarDesdeJson<T>(string ruta) where T : class
        {
            string objetoJson = File.ReadAllText(ruta);
            T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson);

            return objetoDeserealizado;
        }
    }
}
