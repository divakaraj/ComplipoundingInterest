using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Principal = Convert.ToDecimal(Console.ReadLine());
            decimal Rate = Convert.ToDecimal(Console.ReadLine());
            int Term = Convert.ToInt32(Console.ReadLine());
            decimal Interest = 0.00M;
            decimal Amount = 0.00M;
            bool ManualRateChange = false;
            bool FinalRateChanged = false;
            decimal IntermediateCounter = 0;

            for (int i = 1; i <= Term; i++)
            {
                if (i == 1)
                {
                    Amount = Principal;
                }
                if (ManualRateChange && Rate == Convert.ToDecimal(0.2))
                {
                    IntermediateCounter++;
                }
                if (i % 6 == 0)
                {
                    Amount = Amount + (Amount / 3);
                }
                Interest = Math.Round(((Amount * Rate) / 100), 2, MidpointRounding.AwayFromZero);
                Amount = Math.Round(Amount + Interest, 2, MidpointRounding.AwayFromZero);
                if (i % 4 == 0)
                {
                    Amount = Amount - (Amount / 8);
                }
                if (i % 15 == 0 && !FinalRateChanged)
                {
                    Rate = Rate - Convert.ToDecimal(.75);
                    if (Rate <= 0)
                    {
                        Rate = .2M;
                        ManualRateChange = true;
                    }
                }
                if (IntermediateCounter == 10 && !FinalRateChanged)
                {
                    Rate = 0.1M;
                    FinalRateChanged = true;
                }
            }
            Amount = Math.Round(Amount, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine(Amount);
            Console.ReadLine();
        }
    }
}
