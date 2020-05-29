using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new[] { 30, 55, 13, 65, 97 };

            Console.WriteLine("Sırasız");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
            Array.Sort(arr);

            Console.WriteLine("Sıralı");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Clear(arr, 1, 2);
            Console.WriteLine("Clear");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(arr);
            Console.WriteLine("Reverse");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
