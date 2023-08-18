using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardOfBanks
{
    internal abstract class BankCard
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? CardCode { get; set; }
        public int CVV { get; set; }
        public double Balance { get; set; }

        public abstract double Income(double increase, double percentage);
        public abstract double Expense(double decrease, double percentage);



    }
}
