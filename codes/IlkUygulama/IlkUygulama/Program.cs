using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("İsminiz Nedir ?");

            var girilenIsim = Console.ReadLine();

            Console.WriteLine("Merhaba " + girilenIsim);

            Console.ReadKey();

        }
    }
}
