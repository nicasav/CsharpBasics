using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "1.Kursumuz";
            string kurs2 = "2.Kursumuz";
            string kurs3 = "3.Kursumuz";

            //array
            string[] kurslar = new string[] { "1.Kursumuz",
                "2.Kursumuz",
                "3.Kursumuz",
                "Salamlar"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}