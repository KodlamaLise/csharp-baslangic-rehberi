using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructKavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            OrtakMethodlar metodlar = new OrtakMethodlar();
            var toplam = metodlar.Topla(5, 1);
            Console.WriteLine(toplam);

            Console.ReadKey();

        }
    }
}
