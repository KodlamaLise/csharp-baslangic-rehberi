using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDonusleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(5, 9);
            Console.WriteLine(toplam);

            Console.ReadKey();
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }

    }
}
