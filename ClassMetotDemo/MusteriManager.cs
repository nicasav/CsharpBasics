using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        

        public static void MusteriEkle(string[] musteriArray)
        {

            Musteri musteriID = new Musteri();
            musteriID.Id = int.Parse(musteriArray[0]);
            musteriID.AdSoyad = musteriArray[1];
            musteriID.HesaptakiParaMiktari = double.Parse(musteriArray[2]);
            Console.WriteLine("Id: " + musteriID.Id );
            Console.WriteLine("Ad Soyad: " + musteriID.AdSoyad);
            Console.WriteLine("Hesaptaki Para Miktari: " + musteriID.HesaptakiParaMiktari + " Sisteme eklendi.");

        }
        public static void MusteriListele(string[] musteriID)
        {

            Console.WriteLine("Id: " + musteriID[0]);
            Console.WriteLine("Ad Soyad: " + musteriID[1]);
            Console.WriteLine("Hesaptaki Para Miktari: " + musteriID[2]);
        }
        public static void MusteriSil(string[] musteriID)
        {
            Console.WriteLine("Id: " + musteriID[0]);
            Console.WriteLine("Hesap silindi.");
        }
    }
}
