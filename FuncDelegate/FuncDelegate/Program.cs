
using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        { List<string> isimler = new List<string> { "Deniz", "Umut", "Garip", "Sultan" };
            Func<string, bool> func = new Func<string, bool>(FindDeniz);
            foreach (var item in isimler.Where(func))
            {
                Console.WriteLine(item);
            }
        }

        private static bool FindDeniz(string arg) => arg == "Deniz";
       
    }
}
