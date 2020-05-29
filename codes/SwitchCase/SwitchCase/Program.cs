using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            //switch (deger)
            //{
            //    case kosul1 :
            //        //kod bloğu
            //        break;
            //    case kosul2 :
            //        //kod bloğu
            //        break;

            //    default:
            //        //kosullar geçersiz ise default bloğu işletilir
            //        break;
            //}

            Console.WriteLine("Gün numarasını giriniz : ");
            int gunNo = int.Parse(Console.ReadLine());

            switch (gunNo)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break; 
                default:
                    Console.WriteLine("Girilen değere karşılık bir gün bulunamadı");
                    break;
            }
            Console.ReadKey();
        }
    }
}
