using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 7;
            var b = 12;
            var c = a;

            // ==
            Console.WriteLine(string.Format(" a == b op. : {0}", a == b));
            Console.WriteLine(string.Format(" a == c op. : {0}", a == c));

            if (a == c)
            {
                Console.WriteLine("a c'ye eşittir.");
            }
            else
            {
                Console.WriteLine("a c'ye eşit değildir.");
            }

            // !=
            Console.WriteLine(string.Format(" a != b op. : {0}", a != b));

            // >
            Console.WriteLine(string.Format(" a > b op. : {0}", a > b));

            // <
            Console.WriteLine(string.Format(" a < b op. : {0}", a < b));

            // >=
            Console.WriteLine(string.Format(" a >= b op. : {0}", a >= b));

            // <=
            Console.WriteLine(string.Format(" a <= b op. : {0}", a <= b));

            Console.ReadKey();
        }
    }
}
