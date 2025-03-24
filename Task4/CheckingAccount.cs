using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CheckingAccount:Account
    {
        public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0, double fee= 1.50)
            :base(Name,Balance)
        {
            this.fee = fee;
        }

        public double fee { get; set; }


        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount * (1+(fee*0.01)));
        }


    }
}
