using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class TrustAccount:Account
    {
        public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double interestrata=0)
            :base(Name,Balance)
        {
            Interestrata = interestrata;
        }

        public double Interestrata { get; set; }


        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
               
                return base.Deposit(amount+50);
            }
            else if(amount > 0)
            {
                //Balance += amount ;
                return base.Deposit(amount);
            }
            return false;   
        }
        int c = 0;
        public override bool Withdraw(double amount)
        {
            int year = DateTime.Now.Year;
            if (amount < (0.2 * Balance))
            {
                if (year == DateTime.Now.Year)
                {
                    c++;
                   
                }
                if (c <= 3)
                {
                    return base.Withdraw(amount);
                }
                
               
            }
            else
            {
                return false;
            }
            return false ;

        }

    }
}
