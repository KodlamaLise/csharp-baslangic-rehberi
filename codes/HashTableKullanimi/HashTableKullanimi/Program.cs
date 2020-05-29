using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new Hashtable();

            arr.Add("bir", "one");
            arr.Add("iki", "two");
            arr.Add(3, "üç");
            arr.Add("dört", 4);

            foreach (DictionaryEntry item in arr)
            {
                Console.WriteLine(string.Format("{0} : {1}", item.Key, item.Value));
            }

            Console.ReadKey();
        }
    }
}
