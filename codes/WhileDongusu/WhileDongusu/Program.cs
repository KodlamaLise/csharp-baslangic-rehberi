using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            var rndSayi = rnd.Next(1, 16);

            Console.WriteLine("Tahminin nedir? ");
            var tahmin = int.Parse(Console.ReadLine());

            var tahminSayisi = 0;
            while (rndSayi != tahmin)
            {
                //tahmin edilemedi bir daha so
                Console.WriteLine("Tahminin nedir? ");
                tahmin = int.Parse(Console.ReadLine());
                ++tahminSayisi;
            }

            Console.WriteLine("İstenen Sayı : " + rndSayi);
            Console.WriteLine("Tahmin deneme sayısı : " + tahminSayisi)

            Console.ReadKey();

        }
    }
}
