using System;

namespace Second_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dict dict = new Dict(TypeDictionary.UKR_ANGLO);
            dict.AddWord("Ніс", "Nose");
        }
    }
}
