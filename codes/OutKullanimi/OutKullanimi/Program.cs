using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            int buyukSayi;
            Maks(55, 67, out buyukSayi);
            Console.WriteLine("Büyük Sayı : " + buyukSayi);

            Console.ReadKey();
        }

        static void Maks(int a, int b, out int maks)
        {
            if (a > b)
            {
                maks = a;
            }
            else
            {
                maks = b;
            }
        }

    }
}
