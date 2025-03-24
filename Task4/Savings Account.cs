using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Savings_Account : Account
    {
        public Savings_Account(string Name = "Unnamed Account", double Balance = 0.0, double interestrata=0)
            : base(Name, Balance)
        
            {
                this.Interestrata = interestrata;
            }
        
        public double Interestrata { get; set; }


        
    }
}
