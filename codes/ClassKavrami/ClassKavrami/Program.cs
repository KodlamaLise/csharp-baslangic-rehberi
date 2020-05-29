using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Calistir();

            Araba araba2 = new Araba();
            

            var araba3 = new Araba("Ford", "Mustang");
            araba3.Calistir();

            araba2.BenzinAl();

            araba3.BenzinAl(15);

            var araba4 = Araba.ArabaYarat();
            araba4.Calistir();

            araba1.Yil = 2014;
            Console.WriteLine("Yıl : " + araba1.Yil);

            araba1.Yil = 2020;
            Console.WriteLine("Yıl : " + araba1.Yil);

            araba1.Marka = "Fiat";
            Console.WriteLine(araba1.Marka);

            Console.ReadKey();
        }
    }
}
