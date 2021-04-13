using System;
using SerializeLibrary;

namespace Four_Task
{
    [Serializable]
    public class Persone
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return $"Name: {Name},\n" +
                $"Age: {Age},\n" +
                $"Location: {Location}" +
                $"Hobby: {Hobby}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persone persone = new Persone()
            {
                Name = "Vadim ShoStackOverflow",
                Age = 19,
                Location = "city Rivne\n",
                Hobby = "Write code"
            };

            BinSerialize binSerialize = new SerializeLibrary.BinSerialize();
            //binSerialize.SerializeObject("test.dat", persone);
            //binSerialize.DeserializeObject("test.dat", persone);

            JSONSer ser = new SerializeLibrary.JSONSer();
            ser.SerializeJSON("persone.json", persone); 

            //XMLSer ser = new SerializeLibrary.XMLSer();
            //ser.XMLSerialize("test_1.xml", persone);
            //ser.XMLDeserialize("test_1.xml", persone);

        }
    }
}
