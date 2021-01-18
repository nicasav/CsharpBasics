using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Nidai Çağrı Savran";
            kurs1.IzlenmeOrani = 47;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ali Oktay";
            kurs2.IzlenmeOrani = -100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Özgür Deniz Akbay";
            kurs3.IzlenmeOrani = 99;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C";
            kurs4.Egitmen = "İpek Gökaltun";
            kurs4.IzlenmeOrani = 74;
            kurs4.toString();

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            Console.WriteLine(kurs3);
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        public void toString()
        {
            Console.WriteLine("merhaba");
        }
    }
}