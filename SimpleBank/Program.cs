using System;

namespace SimpleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Checking Account with initial balance
            CheckingAccount checking = new CheckingAccount("John", "Doe", 2500.0m);

            // Create the Savings Account with interest and initial balance
            SavingsAccount saving = new SavingsAccount("Jane", "Doe", 0.025m, 1000.0m);

            // Check the balances
            // Expected output should be 2500 and 1000 at this point
            checking.DisplayBalance();
            saving.DisplayBalance();

            // Print the account owner information. Expected output: 
            // "Checking owner: John Doe"
            // "Savings owner: Jane Doe"
            checking.DisplayOwner();
            saving.DisplayOwner();

            // Deposit some money in each account
            checking.Deposit(200.0m);
            saving.Deposit(150.0m);

            // Check the balances
            // Expected output should be 2700 and 1150 at this point
            checking.DisplayBalance();
            saving.DisplayBalance();

            // Make some withdrawals from each account
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

            // Check the balances
            // Expected output should be 2650 and 1025 at this point
            checking.DisplayBalance();
            saving.DisplayBalance();

            // Apply the Savings interest
            saving.ApplyInterestToAccount();
            // Savings balance should now be 1050.63 
            saving.DisplayBalance();

            // More than 3 Savings withdrawals should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
            // Savings balance should now be 988.63
            saving.DisplayBalance();

            // try to overdraw savings - this should be denied and print message
            saving.Withdraw(2000.0m);

            // try to overdraw checking - should result in extra charge
            checking.Withdraw(3000.0m);

            // Expected output should be -385 and 988.63
            checking.DisplayBalance();
            saving.DisplayBalance();
        }
    }
}
