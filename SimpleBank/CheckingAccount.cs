using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    /// <summary>
    /// Checking bank account. Has an overdrawn charge of 35.
    /// Allows to over draw
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        private const int OVERDRAWNCHARGE = 35;

        public CheckingAccount(string firstName, string lastName, decimal balance) 
            : base(firstName, lastName, balance)
        {

        }

        public override void Withdraw(decimal withdrawAmount)
        {
            withdrawAmount += withdrawAmount > Balance ? OVERDRAWNCHARGE : 0;
            base.Withdraw(withdrawAmount);
        }

        public override void DisplayBalance()
        {
            Console.WriteLine($"Checking balance is {Balance:C2}");
        }

        public void DisplayOwner()
        {
            Console.WriteLine($"chekcing owner: {AccountOwner}");
        }
    }
}
