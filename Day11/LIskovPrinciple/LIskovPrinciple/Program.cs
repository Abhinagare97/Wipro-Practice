using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    public class BankAccount
    {

        protected double balance;

        public virtual void Deposit(double amount)
        {

            balance += amount;
        }

        public virtual void withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient Balance");

            }

        }

        public double GetBalance()
        {
            return balance;
        }
    }

    public class FixedDeposit : BankAccount
    {

        public override void withdraw(double amount)
        {
            base.withdraw(amount);
            throw new InvalidOperationException("cannot withdraw from a fixed deposit account");
        }

    }
}
