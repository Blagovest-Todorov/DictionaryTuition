using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class DictionaryHashTableMap
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            phonebook.Add("John Smith", "+123456789");
            phonebook.Add("Giovani", "+35688879952");
            phonebook.Add("Peter", "+359 2574629");

            phonebook.Remove("John Smith");
            foreach (KeyValuePair <string, string> pair in phonebook)
            {
                Console.WriteLine(" Name: {0} --Telephone:--{1}", pair.Key, pair.Value );
            }
            //foreach (string key in phonebook.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach (string value in phonebook.Values)
            //{
            //    Console.WriteLine(value);
            //}
            //foreach ( KeyValuePair<string, string> pair in phonebook )
            //{
            //    Console.WriteLine( pair.Key + " " + pair.Value  );
            //}
            foreach (var pair in phonebook)
            {
                Console.WriteLine(pair.Key + " " + pair.Value); //prointing the key and value pair !
            }
        }
    }
}
