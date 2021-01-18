using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //type safety
            //do not repeat yourself

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
