using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList sl = new SortedList();

            sl.Add(01, "Pazartesi");
            sl.Add(02, "Salı");
            sl.Add(03, "Çarşamba");
            sl.Add(04, "Perşembe");
            sl.Add(05, "Cuma");
            sl.Add(06, "Cumartesi");
            sl.Add(07, "Pazar");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(string.Format("{0} : {1}", item.Key, item.Value));
            }

            Console.ReadKey();
        }
    }
}
