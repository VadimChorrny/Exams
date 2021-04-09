using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Ось будинок, який побудував Джек." +
                "А це пшениця, Яка в темній комірці зберігається У будинку," +
                "Який побудував Джек. А це весела птиця-синиця," +
                "Яка часто краде пшеницю, Яка в темній комірці зберігається У будинку," +
                "Який побудував Джек.";
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] newText = text.Split(' ');
            foreach (var item in newText)
            {
                string tmp = item;
                item.Trim('.', ',');
                if(words.ContainsKey(item))
                {
                    int tmpValue = 1;
                    words.TryGetValue(item, out tmpValue);
                    tmpValue++;
                    words[item] = tmpValue;
                }
                else
                {
                    words.Add(item, 1);
                }
            }

            int id = 0;
            Console.WriteLine($"{"Word",20}{"Count",20}");
            foreach (var item in words)
            {
                ++id;
                Console.WriteLine($"{id,0 }. {item.Key,20} {item.Value,20}");

            }
            Console.WriteLine($"All word {words.Count}, unique { (words.Where(x => x.Value == 1).ToArray().Length)}");

        }
    }
}
