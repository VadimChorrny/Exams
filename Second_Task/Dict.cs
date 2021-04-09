using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Second_Task
{
    public enum TypeDictionary { ANGLO_UKR = 1,UKR_ANGLO};
    interface IDictionary
    {
        public void AddWord(string word,string words);
        public void ChangeWord(string word);
        public void RemoveWord(string word);
        public void SearchTranslate(string word);
        public void InputFile(string path);
    }
    class Dict : IDictionary
    {
        
        public Dictionary<string,List<string>> dictionary = new Dictionary<string, List<string>>();
        public TypeDictionary Type;
        public Dict(TypeDictionary type)
        {
            this.Type = type;
        }

        //public void AddToFile(string path, Dictionary<string, List<string>> dict)
        //{
        //    using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
        //    {
                
        //    }
        //}
        public void AddWord(string word, string words)
        {
            if(dictionary.ContainsKey(word))
            {
                dictionary[word].Add(words); // add translate
            }
            else
            {
                dictionary.Add(word, new List<string> { words });
            }
        }

        public void ChangeWord(string word)
        {
            throw new NotImplementedException();
        }

        public void InputFile(string path)
        {
            //File.WriteAllText(path, dictionary);
        }

        public void RemoveWord(string word,List<string>words)
        {
            dictionary.Remove(word);
            //if (dictionary.ContainsKey(word))
            //{
            //    dictionary.Remove(word,out words);
            //}
        }

        public void RemoveWord(string word)
        {
            throw new NotImplementedException();
        }

        public void SearchTranslate(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                foreach (var item in dictionary[word])
                {
                    Console.WriteLine($"Searched word - {item}");
                }
            }
        }

    }
}
