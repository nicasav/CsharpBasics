using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Acıklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 47;
            urun2.Acıklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("--------------------------------------");

            }

            Console.WriteLine("----------------Metotlar------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 18);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 35);


        }
    }
}