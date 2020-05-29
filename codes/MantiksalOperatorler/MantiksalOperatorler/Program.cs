using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = true;
            var b = true;

            // &&
            Console.WriteLine(string.Format(" a && b : {0}", a && b));

            b = false;

            Console.WriteLine(string.Format(" a && b : {0}", a && b));

            b = true;

            // ||
            Console.WriteLine(string.Format(" a || b : {0}", a || b));

            a = false;
            b = false;
            Console.WriteLine(string.Format(" a || b : {0}", a || b));

            // !
            Console.WriteLine(string.Format("!a : {0}", !a));

            Console.ReadKey();

        }
    }
}
