
namespace ClassKavrami
{

    class Araba
    {

        public string Marka { get; set; }

        private int _yil;
        public int Yil
        {
            get
            {
                return _yil;
            }
            set
            {
                if (value > 2014)
                {
                    _yil = 0;
                }
                else
                {
                    _yil = value;
                }
            }
        }

        public Araba()
        {

        }
        public Araba(string marka, string model)
        {
            Calistir();
        }

        public void Calistir()
        {
            //Araba çalışacak
            System.Console.WriteLine("Araba çalıştı");
        }

        public void BenzinAl()
        {
            System.Console.WriteLine("Depo dolduruldu");
        }

        public void BenzinAl(byte miktar)
        {
            System.Console.WriteLine(string.Format("Depoya {0} lt benzin eklendi", miktar));
        }
        //public, private, internal, protected

        public static Araba ArabaYarat()
        {
            return new Araba();
        }

    }
}
