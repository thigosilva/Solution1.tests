using Sample.Extensions;
using System;

namespace Sample.Terminal
{
    class Program
    {
        static void Main()
        {
            //var dateNow = DateTime.Now;
            double valuePayment = 100.54;

            //Console.WriteLine(dateNow.ToStringShortPtBR());
            Console.WriteLine(valuePayment.ToStringMoneyPtBR());
        }
    }
}
