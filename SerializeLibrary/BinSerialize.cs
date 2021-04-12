using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeLibrary
{

    public class BinSerialize
    {
        public BinaryFormatter formatter = new BinaryFormatter();
        public void SerializeObject(string path, object ts)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ts);
            }
        }
        public void DeserializeObject<T>(string path, T test)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T result = (T)formatter.Deserialize(fs);
                Console.WriteLine(test);
            }
        }
    }
}
