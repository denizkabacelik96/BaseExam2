using System;

namespace ExtentionMetod.Deniz
{
    class Program
    {
        static void Main(string[] args)
        {
            Genislet genislet = new Genislet();
            Console.WriteLine(genislet.Cikar(10,2));
        } }
        class Genislet
        {
            public int Bol(int sayi1, int sayi2) { 
                return sayi1/sayi2;
            }
            public int Çarp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
     
        
        
        }
        static class İslemEkle { 
        
        public static int Cikar(this Genislet islem, int sayi1, int sayi2)
            {

                return sayi1 - sayi2;
            }
        }
    }



