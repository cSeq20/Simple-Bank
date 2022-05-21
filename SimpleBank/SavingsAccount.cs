using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    /// <summary>
    /// Saving bank account. Has a free withdrawal limit of 3.
    /// No overdraws allowed.
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        private const int WITHDRAW_LIMIT = 3;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private int _numWithdrawals { get; set; }
        public decimal InterestRate { get; set; }
        

        public SavingsAccount(string fname, string lname, decimal interestRate, decimal balance)
            : base (fname, lname, balance)
        {
            this.InterestRate = interestRate;
        }

        public void ApplyInterestToAccount()
        {
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings denied");
            }
            else
            {
                _numWithdrawals++;
                base.Withdraw(withdrawAmount);
                if (_numWithdrawals > WITHDRAW_LIMIT)
                {
                    base.Withdraw(WITHDRAW_CHARGE);
                }
            }
        }

        public override void DisplayBalance()
        {
            Console.WriteLine($"Savings balance is {Balance:C2}");
        }

        public void DisplayOwner()
        {
            Console.WriteLine($"Savings owner: {AccountOwner}");
        }
    }
}
