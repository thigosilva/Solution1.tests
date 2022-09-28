using Sample.Extensions;
using System;

namespace Sample.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //var datenow = DateTime.Now;
            //double valuePayment = 100.54;
            var emailValue = "teste.teste.com";

            //Console.WriteLine(datenow.ToStingShortPtBR());
            //Console.WriteLine(valuePayment.ToStringMoneyPtBR());
            Console.WriteLine(emailValue.IsValidMail());
        }
       
    }
}
