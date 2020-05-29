using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 8;

            // +
            Console.WriteLine(string.Format("+ op. : {0}", a + b));

            // -
            Console.WriteLine(string.Format("- op. : {0}", a - b));

            // *
            Console.WriteLine(string.Format("* op. : {0}", a * b));

            // /
            Console.WriteLine(string.Format("/ op. : {0}", a / b));

            // %
            Console.WriteLine(string.Format("% op. : {0}", a % b));

            // ++
            Console.WriteLine(string.Format("++ op. : {0}", a++));

            // --
            Console.WriteLine(string.Format("-- op. : {0}", b--));

            Console.ReadKey();

        }
    }
}
