using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            var sayi1 = 5;
            var sayi2 = 9;

            Console.WriteLine(string.Format("sayi1 = {0} sayi2 = {1}", sayi1, sayi2));

            Degistir(ref sayi1, ref sayi2);

            Console.WriteLine(string.Format("sayi1 = {0} sayi2 = {1}", sayi1, sayi2));

            Console.ReadKey();
        }

        static void Degistir(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

    }
}
