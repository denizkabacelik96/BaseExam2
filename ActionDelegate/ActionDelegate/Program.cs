using System;
using System.Collections.Generic;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            Action<int> action = new Action<int>(BringNumber);
            sayilar.ForEach(action);
        }

        private static void BringNumber(int obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
