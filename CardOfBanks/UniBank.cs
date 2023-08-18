using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardOfBanks
{
    internal class UniBank : BankCard
    {

        public override double Income(double increase, double percentage)
        {
            double fakeIncrease = increase;
            fakeIncrease /= 100;
            fakeIncrease *= percentage;
            increase -= fakeIncrease;
            if (increase <= 0)
            {
                Console.WriteLine("The amount was not entered correctly");
                return Balance;
            }

            return Balance += increase;
        }

        public override double Expense(double decrease, double percentage)
        {
            double fakeDecrease = decrease;
            fakeDecrease /= 100;
            fakeDecrease *= percentage;
            decrease += fakeDecrease;
            if (decrease <= 0 || decrease > Balance)
            {
                Console.WriteLine("The amount was not entered correctly");
                return Balance;
            }

            return Balance -= decrease;
        }
    }
}
