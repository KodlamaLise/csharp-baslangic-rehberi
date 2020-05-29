using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            //if(kosul)
            //{
                //Doğru ise işletilecek kod
            //}else
            //{
                //Yanlış ise işletilecek kod
            //}

            //if(kosul)
            //{
                //Doğru ise işletilecek kod
            //}else if(2.kosul)
            //{
                //1. koşul doğru değil ise 2. koşul kontrol edilir.
                //Doğru ise işletilecek kod
            //}else
            //{
                //Yanlış ise işletilecek kod
            //}

            Console.WriteLine("Bir sayı giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            if (girilenSayi == 0)
            {
                Console.WriteLine("Girdiğiniz sayı 0'a eşit.");
            }
            else if (girilenSayi > 0)
            {
                Console.WriteLine("Girdiğiniz sayı pozitif.");
            }
            else if (girilenSayi < 0)
            {
                Console.WriteLine("Girdiğiniz sayı negatif.");
            }

            Console.ReadKey();
        }
    }
}
