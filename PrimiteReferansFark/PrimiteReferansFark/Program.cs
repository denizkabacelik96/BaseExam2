using System;

namespace PrimiteReferansFark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = new string[] {"Ankara","İstanbul","İzmir" };
            string[] sehirler2 = new string[] { "Çankırı", "Çorum", "Çanakkale" };
            sehirler2 = sehirler1;
            sehirler2[0] = "Kastamonu";
            Console.WriteLine(sehirler1[0]);
            Console.ReadLine();
        }
    }
}
