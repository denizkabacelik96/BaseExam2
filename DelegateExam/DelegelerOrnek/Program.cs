using System;

namespace DelegelerOrnek
{
    class Program
    {

        public delegate void MyDelegate();
        
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
           // customer.SendMessage();
         //   customer.ShowAlert();
            MyDelegate myDelegate = customer.SendMessage;
            myDelegate += customer.ShowAlert;
            myDelegate();
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {

        public void SendMessage()
        {

            Console.WriteLine("Hello");

        }
        public void ShowAlert()
        {

            Console.WriteLine("Be Careful");

        }
    }
}
