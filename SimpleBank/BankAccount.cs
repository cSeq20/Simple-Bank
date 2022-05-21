using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    /// <summary>
    /// Base bank account class.
    /// </summary>
    public abstract class BankAccount
    {
        private string _firstName;
        private string _lastName;
        public decimal Balance { get; set; }
        public string AccountOwner
        {
            get => $"{_firstName} {_lastName}";
        }

        public BankAccount(string firstName, string lastName, decimal balance=0.0m)
        {
            _firstName = firstName;
            _lastName = lastName;
            Balance = balance;
        }

        public virtual void Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
        }

        public virtual void Withdraw(decimal withdrawAmount)
        {
            Balance -= withdrawAmount;
        }

        public virtual void DisplayBalance()
        {
            Console.WriteLine($"Balance is {Balance:C2}");
        }
    }
}
