using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenaryOperator
{
    class Program
    {
        static void Main(string[] args)
        { 
             //Tenary
             // kosul ? doğru ifade : yanlış ifade 

            Console.WriteLine("Bir sayısı giriniz : ");

            int sayi = int.Parse(Console.ReadLine());

            var msj = "";

            msj = sayi % 2 == 0 ? "Çift sayı girildi" : "Tek sayı girildi";

            Console.WriteLine(msj);

            Console.ReadKey();
        }
    }
}
