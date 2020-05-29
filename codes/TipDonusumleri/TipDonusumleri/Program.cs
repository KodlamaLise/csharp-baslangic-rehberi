using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //explicit
            double d = 145.78;
            int i = (int)d;

            Console.WriteLine(d);
            Console.WriteLine(i);

            //implicit
            int j = 67;
            double t = j;

            var sonuc = Convert.ToInt16(i);
            Console.WriteLine(sonuc);

            Console.ReadKey();
        }
    }
}
