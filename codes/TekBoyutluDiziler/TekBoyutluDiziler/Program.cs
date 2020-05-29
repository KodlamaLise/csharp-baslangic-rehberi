using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {

            var gunler1 = new string[7];

            gunler1[0] = "Pazartesi";
            gunler1[1] = "Salı";
            gunler1[2] = "Çarşamba";
            gunler1[3] = "Perşembe";
            gunler1[4] = "Cuma";
            gunler1[5] = "Cumartesi";
            gunler1[6] = "Pazar";

            //Console.WriteLine(gunler[3]);

            for (int i = 0; i < gunler1.Length; i++)
            {
                //Console.WriteLine(gunler1[i]);
            }

            var gunler2 = new string[] { 
                "Pazartesi",
                "Salı",
                "Çarşamba",
                "Perşembe",
                "Cuma",
                "Cumartesi",
                "Pazar"
            };

            Console.WriteLine(gunler2[4]);

            for (int i = 0; i < gunler2.Length; i++)
            {
                Console.WriteLine(gunler2[i]);
            }

            Console.ReadKey();
        }
    }
}
