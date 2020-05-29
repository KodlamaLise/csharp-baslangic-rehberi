using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtamaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 5;
            var b = 4;

            // =
            var c = a;
            Console.WriteLine(string.Format("= op. : {0}", c));

            // +=
            Console.WriteLine(string.Format("+= op. : {0}", a += b));

            //Console.WriteLine(a);

            // -=
            Console.WriteLine(string.Format("-= op. : {0}", a -= b));
            // a = a - b

            // *=
            Console.WriteLine(string.Format("*= op. : {0}", a *= b));

            // /=
            Console.WriteLine(string.Format("/= op. : {0}", a /= b));

            // %=
            Console.WriteLine(string.Format("%= op. : {0}", a %= b));

            Console.ReadKey();

        }
    }
}
