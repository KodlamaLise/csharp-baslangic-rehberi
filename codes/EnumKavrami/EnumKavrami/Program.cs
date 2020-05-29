using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            var gun = Gunler.Pazar;
            Console.WriteLine((int)gun);

            var birim = Birimler.Yarım;
            Console.WriteLine(birim);
            Console.WriteLine((int)birim);

            gun = Gunler.Carsamba;
            Console.WriteLine((int)gun);

            gun = Gunler.Persembe;
            Console.WriteLine((int)gun);

            var day = DayOfWeek.Thursday;
            Console.WriteLine(day);
            Console.WriteLine((int)day);

            Console.ReadKey();
        }
        enum Gunler
        {
            Pazartesi = 5,
            Sali,
            Carsamba = 15,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        }
    }
    enum Birimler
    {
        Ceyrek = 25,
        Yarım = 50,
        Tam = 100
    }
}
