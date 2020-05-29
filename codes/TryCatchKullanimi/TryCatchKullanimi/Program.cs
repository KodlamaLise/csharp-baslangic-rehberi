using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 45;
            var b = 0;

            if (b != 0)
            {
                //Console.WriteLine(a / b);
            }
            else
            {
                //Console.WriteLine("Sıfıra bölme işlemi gerçekleştirelemez");
            }

            var str = "strVal";
            //var i = int.Parse(str);

            int result;
            if (int.TryParse(str, out result))
            {
                //Console.WriteLine("Cast işlemi gerçekleşti");
            }
            else
            {
                //Console.WriteLine("Cast işleminde sorun oluştu");
            }

            try
            {
                // hata ihtimali olan kod yazılır
                Console.WriteLine(a / b);
            }
            catch (FormatException ex)
            {
                //Format hatası ise
            }
            catch (DivideByZeroException ex)
            {
                //Hata oluşması durumundaki kod
                //Bölme hatası ise
                //throw ex;
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //Yukarıda handle edilmeyen tüm hatalar buraya gelir.
            }
            finally
            {
                //hata olsada olmasada çalışacak olan kod yazılır
                Console.WriteLine("Kaynaklar serbest bırakıldı");
            }

            Console.ReadKey();
        }
    }
}
