using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            var tekToplamlar = 0;
            var ciftToplamlar = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    // i çift sayıdır
                    ciftToplamlar += i;
                    //ciftToplamlar = ciftToplamlar + i;
                    Console.WriteLine("Çift : " + i);
                }
                else
                {
                    //i tek sayıdır
                    tekToplamlar += i;
                    Console.WriteLine("Tek : " + i);
                }
            }

            Console.WriteLine("Tek Sayıların Toplamı : " + tekToplamlar);
            Console.WriteLine("Çift Sayıların Toplamı : " + ciftToplamlar);

            Console.ReadKey();
        }
    }
}
