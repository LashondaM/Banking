﻿using System;

namespace Banking
{
    class Program
    {
        static void Method1()
        {
            try
            {
                Method2();
            } catch(Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}");
            }
        }
        static void Method2()
        {
            Method3();
        }
        static void Method3()
        {
            var throwException = true;
            if (throwException)
            {
                throw new Exception("My fictitous exception!");
            }
        }
        static void Main(string[] args)
        {
            Method1();

            //var n = 1;
            //var d = 0;
            ////var x = n / d;
            //try
            //{
            //    var x = n / d;

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Divid by Zero avoided");
            //} finally
            //{

            //}

            //var sav2 = new Savings2(100);
            //sav2.Description = "Lashonda's Savings2"; // right click, run to cursor, stops executing when it hits a line you right clicked on and selected
            //sav2.InterestRate = 0.12m;
            //sav2.Print();
            //sav2.Deposit(5000);
            //sav2.Withdraw(2000);
            //sav2.CalculateAndPayInterest(1);
            //sav2.Print();





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
