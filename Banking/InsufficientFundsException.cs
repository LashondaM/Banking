﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class InsufficientFundsException : Exception
    {
        public decimal CurrentBalance { get; set; }
        public decimal AmountToWithdraw { get; set; }

        public InsufficientFundsException(decimal CurrentBalance, decimal AmountToWithdraw) : base() {
            
            this.CurrentBalance = CurrentBalance;
            this.AmountToWithdraw = AmountToWithdraw;
        }
        public InsufficientFundsException() : base() { }

        public InsufficientFundsException(string Message) : base(Message) { }

        public InsufficientFundsException(string Message, Exception InnerExpception) : base(Message, InnerExpception) { }
    }
}
