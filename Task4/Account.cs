﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Account
    {
        
            public string Name { get; set; }
            public double Balance { get; set; }

            public Account(string Name = "Unnamed Account", double Balance = 0.0)
            {
                this.Name = Name;
                this.Balance = Balance;
            }

            public virtual bool Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    return true;
                }
                return false;
            }

            public virtual bool Withdraw(double amount)
            {
                if (Balance - amount >= 0)
                {
                    Balance -= amount;
                    return true;
                }
                return false;
            }
        public override string ToString()
        {
            return $"Name: {Name}, Balance: {Balance}";
        }
        public  static double operator +(Account account,Account account1)
        {
            return account.Balance+account1.Balance;
        }


    }
} 

