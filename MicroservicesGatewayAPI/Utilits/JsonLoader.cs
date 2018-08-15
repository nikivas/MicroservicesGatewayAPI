using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesGatewayAPI.Utilits
{
    public class JsonLoader
    {
        public static T LoadFromFile<T>(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
                
        }

        public T Deserialize<T>(object json)
        {
            return JsonConvert.DeserializeObject<T>(Convert.ToString(json));
        }

    }
}
