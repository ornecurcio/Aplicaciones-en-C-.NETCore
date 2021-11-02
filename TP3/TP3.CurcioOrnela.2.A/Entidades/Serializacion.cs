using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization; 

namespace Entidades
{
    public class Serializacion
    {
        public static string GenerarRuta(string titulo)
        { 
            string rutaAlt = AppDomain.CurrentDomain.BaseDirectory; 
            string rutaArchivo = Path.Combine(rutaAlt, titulo);
            return rutaArchivo;
        }
        public static void SerializarAJason<T>(string ruta, T obj) where T : class
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();//{ Converters = {new JsonStringEnumConverter()} };
            jsonSerializerOptions.WriteIndented = true;
            
            string objetoJson = JsonSerializer.Serialize(obj, jsonSerializerOptions);

            File.WriteAllText(ruta, objetoJson);
        }
        public static T DeserealizarDesdeJson<T>(string ruta) where T : class
        {
            string objetoJson = File.ReadAllText(ruta);
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
            jsonSerializerOptions.WriteIndented = true;

            T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson,jsonSerializerOptions);

            return objetoDeserealizado;
        }
    }
}
