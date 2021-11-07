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
    public class SerializacionAJason 
    {
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
        public static void SerializarAJason<T>(string ruta, T obj) where T : class
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize(obj, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo serealizar", ex); 
            }
        }
        public static T DeserealizarDesdeJson<T>(string ruta) where T : class
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                return objetoDeserealizado;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo desealizar", ex);
            }
        }
    }
}
