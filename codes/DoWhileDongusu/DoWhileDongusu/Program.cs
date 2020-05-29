using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            var pass = "1357";

            do
            {
                Console.WriteLine("Şifre : ");
            } while (pass != Console.ReadLine());

            Console.WriteLine("Tebrikler şifre doğru");

            Console.ReadKey();
        }
    }
}
