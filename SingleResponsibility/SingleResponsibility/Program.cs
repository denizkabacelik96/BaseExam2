using System;
using System.ComponentModel.DataAnnotations;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Musteri
    {
        public int Id { get; set; }
     //  [Required(ErrorMessage ="Ad alanı  boş  geçirilemez")]
        public int Ad { get; set; }
       // public void Kaydet() {
         //   Console.WriteLine("Kaydedildi");
        
        }
    }

    public class MusteriValidator { 
        
        public  static bool AdDogrula(string ad) {

            if (string.IsNullOrWhiteSpace(ad))
                return false;
            return true;
        }


        class EfMusteri {
            public void Kaydet()
            {
                Console.WriteLine("Kaydedildi");
            }
    }


}
