using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            var dizi = new int[] { 1, 5, 6, 3, 8, 8, 9, 6 };

            var i = 0;
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
                ++i;
            }

            Console.WriteLine("Dizi Sayısı : " + i);

            Console.ReadKey();
        }
    }
}
