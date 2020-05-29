using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Komut :> ");
                if ("quit" == Console.ReadLine())
                {
                    break;
                }
            }

            Console.WriteLine("quit komutu çalıştırıldı...");
            Console.ReadKey();
        }
    }
}
