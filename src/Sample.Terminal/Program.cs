using Sample.Extensions;
using System;

namespace Sample.Terminal
{
    class Program
    {
        static void Main()
        {
            //var datenow = DateTime.Now;
            //double valuePayment = 100.54;
            var emailValue = "teste.teste.com";

            //Console.WriteLine(datenow.ToStingShortPtBR());
            //Console.WriteLine(valuePayment.ToStringMoneyPtBR());
            Console.WriteLine("Digite o E-mail:");
            Console.WriteLine(emailValue.IsValidMail());
        }
       
    }
}
