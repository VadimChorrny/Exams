using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SerializeLibrary
{
    public class JSONSer
    {
        public void SerializeJSON<T>(string path, T obj)
        {
            using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                string json = JsonSerializer.Serialize<Object>(obj);
                Console.WriteLine(json);
                T res = (T)JsonSerializer.Deserialize<T>(json);
                Console.WriteLine(res);
            }
        }
    }
}
