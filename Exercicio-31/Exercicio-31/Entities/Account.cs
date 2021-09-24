using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_31.Entities.Exceptions;
namespace Exercicio_31.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdawLimit = withdawLimit;
        }
        public void Deposit(double amount)
        { 
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }
            else if (amount > WithdawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            else
            {
                Balance -= amount;
            }
        }
       
    }
}
