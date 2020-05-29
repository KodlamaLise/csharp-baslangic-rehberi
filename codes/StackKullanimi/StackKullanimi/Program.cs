using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Son giren ilk çıkar

            var cikmazSokak = new Stack();

            cikmazSokak.Push("Beyaz Araba");
            cikmazSokak.Push("Yeşil Araba");
            cikmazSokak.Push("Kırmızı Araba");

            //Console.WriteLine(cikmazSokak.Peek());

            Console.WriteLine(cikmazSokak.Pop());
            Console.WriteLine(cikmazSokak.Pop());
            Console.WriteLine(cikmazSokak.Pop());

            Console.ReadKey();
        }
    }
}
