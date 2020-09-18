using System;
using System.Collections.Generic;

namespace K01.ObjelerinDavranisiDeniz
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = string.Empty;
            List<string> isimler = new List<string>();
            Musteri musteri = new Musteri();
            List<Musteri> musteriler = new List<Musteri>();
            Console.WriteLine("primitive  tip");
            for (int i = 0; i < 30; i++)
            {
                ad = FakeData.NameData.GetFirstName();
                isimler.Add(ad);
            }
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("referans tip");
            for (int i = 0; i < 30; i++)
            {
               
                musteri.Ad = FakeData.NameData.GetFirstName();
                musteriler.Add(musteri);
            }
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Ad);
            }
        }
       
    }
    public class Musteri {
        public string Ad { get; set; }

      
    }
}
