using System.Security.Cryptography;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            //var accounts = new List<Account>();
            //accounts.Add(new Account());
            //accounts.Add(new Account("Larry"));
            //accounts.Add(new Account("Moe", 2000));
            //accounts.Add(new Account("Curly", 5000));

            //AccountUtil.Display(accounts);
            //AccountUtil.Deposit(accounts, 1000);
            //AccountUtil.Withdraw(accounts, 2000);

            // Savings


            //var savAccounts = new List<Account>();
            //savAccounts.Add(new Savings_Account());
            //savAccounts.Add(new Savings_Account("Batman", 2000));
            //savAccounts.Add(new Savings_Account("Wonderwoman", 5000, 5.0));

            //AccountUtil.Display(savAccounts);
            //AccountUtil.Deposit(savAccounts, 1000);
            //AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            //var trustAccounts = new List<Account>();
            //trustAccounts.Add(new TrustAccount());
            //trustAccounts.Add(new TrustAccount("Superman2"));
            //trustAccounts.Add(new TrustAccount("Batman2", 2000));
            //trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            //AccountUtil.Display(trustAccounts);
            //AccountUtil.Deposit(trustAccounts, 1000);
            //AccountUtil.Deposit(trustAccounts, 6000);

            ////AccountUtil.Withdraw(trustAccounts, 1000);
            ////AccountUtil.Withdraw(trustAccounts, 1000);
            ////AccountUtil.Withdraw(trustAccounts, 800);
            ////AccountUtil.Withdraw(trustAccounts, 600);

            //AccountUtil.Withdraw(trustAccounts, 2000);
            //AccountUtil.Withdraw(trustAccounts, 3000);
            //AccountUtil.Withdraw(trustAccounts, 500);

            //Account a1 = new("Merna", 5000);
            //Account a2 = new("Talia", 8050);
            //double a3= a1 + a2;

            //Console.WriteLine(a3);
        }
    }
}
