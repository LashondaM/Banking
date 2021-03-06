using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmountGreaterThanZeroException();

                //Console.WriteLine("Insufficient funds!");
                //return false;
            }
            this.Balance += amount; // this way is shorter
            return true;
            //this.Balance = this.Balance + amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
            }
                if (amount > this.Balance)
                {
                    throw new InsufficientFundsException(this.Balance, amount);
                    //Console.WriteLine("Insufficient funds!");
                    //return false;
                }

                this.Balance -= amount;
                return true;

            //else
            //    throw new AmountGreaterThanZeroException();
        }

        public bool Transfer(decimal amount, Account ToAccount)
        {
            var success = this.Withdraw(amount);
            if (success)
            {
                ToAccount.Deposit(amount);
            }
            return true;
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
