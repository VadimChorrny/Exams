using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SerializeLibrary
{
    public class XMLSer
    {
        public void XMLSerialize<T>(string path, T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using(FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("[XML]Object has been serializated!");
            }
        }

        public void XMLDeserialize<T>(string path, T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                T newObject = (T)formatter.Deserialize(fs);
                Console.WriteLine($"[XML] Object has been deserialize\n\n\n" +
                    $"Have ->\n" +
                    $"---{obj}");
            }
        }
    }
}
