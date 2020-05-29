using BankaOperasyonlari.BireyselBankacilik;
using BankaOperasyonlari.KurumsalBankacilik;

namespace NamespaceKavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            var bireyselKredi =
                new BankaOperasyonlari.BireyselBankacilik.BireyselKredi();
            var bKredi = new BireyselKredi();

            var kurumsalKredi =
                new BankaOperasyonlari.KurumsalBankacilik.KurumsalKredi();
            var kKredi = new KurumsalKredi();

        }
    }
} 