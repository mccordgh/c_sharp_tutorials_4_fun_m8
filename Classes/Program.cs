using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matty", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch
            {
                Console.WriteLine("Withdrawal not allowed. Will overdraft.");
            }

            Console.WriteLine();
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
