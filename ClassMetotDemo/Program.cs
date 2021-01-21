using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> MusteriListesi = new List<int>();
            string[] musteri = new string[] { "12", "Nayday", "720" };
            MusteriManager.MusteriEkle(musteri);
            MusteriManager.MusteriListele(musteri);
            MusteriManager.MusteriSil(musteri);

        }
        
    }
}
