using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            string str = "vidobu.com";
            object obj = str;

            //Unboxing
            var unBox = (string)obj;

            Console.WriteLine(string.Format("{0} - {1}", obj.GetType(), obj));
            Console.WriteLine(string.Format("{0} - {1}", unBox.GetType(), unBox));


            Console.ReadKey();

        }
    }
}
