using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {



            var sav2 = new Savings2(100);
            sav2.Description = "Lashonda's Savings2"; // right click, run to cursor, stops executing when it hits a line you right clicked on and selected
            sav2.InterestRate = 0.12m;
            sav2.Print();
            try
            {
                sav2.Deposit(5000);
                sav2.Withdraw(2000);
                sav2.CalculateAndPayInterest(1);
                sav2.Print();
            
                sav2.Withdraw(100000);
            } catch (AmountGreaterThanZeroException)
            {
                Console.WriteLine("Amount cannot be zero or negative");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("You don't have enough in yout account");
                Console.WriteLine($"Current balance is {ex.CurrentBalance}");
                Console.WriteLine($"Amount to withdraw is {ex.AmountToWithdraw}");
            }
            





            //var sav1 = new Savings()
            //{
            //    Id = 10,
            //    Description = "My First Savings"
            //};
            // sav1.InterestRate = 0.12m;
            //sav1.Print();
            //sav1.Deposit(5000);
            //sav1.Withdraw(2000);
            //sav1.CalculateAndPayInterest(1);
            //sav1.Print();

            //var acct1 = new Account()
            //{
            //    Id = 1, Description = "Test account"
            //};
            //acct1.Print();
            //acct1.Deposit(9500);
            //acct1.Print();
            //acct1.Withdraw(6000);
            //acct1.Print();
            //acct1.Withdraw(4000);
            //acct1.Print();

            //var acct2 = new Account()
            //{
            //    Id = 2,
            //    Description = "New Account"
            //};
            //acct1.Transfer(1500, acct2);
            //acct1.Print();
            //acct2.Print();

            //acct1.Withdraw(-1000);
            //acct1.Print();
        }
    }
}
