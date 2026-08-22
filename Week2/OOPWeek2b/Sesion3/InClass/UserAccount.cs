using System;
using System.Collections.Generic;
using System.Text;

namespace InClass
{
    internal class UserAccount
    {
        // 1. Private backing fields (where needed)
       

        // TODO 1: AccountId (Init-Only)
        private string accountId;
        public string AccountId
        {
            get { return accountId; }
            init 
            {   if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("AccountId cannot be null or empty.");
                }
                else
                {
                    accountId = value;
                }
            }
        }
        // TODO 2: Username (Auto-Implemented)
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username cannot be null or empty.");
                }
                else
                {
                    username = value;
                }
            }
        }

        // TODO 3: Password (Write-Only)
        private string password;
        public string Password
        {
            get
            {
                throw new InvalidOperationException("Password thì không được xem");
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Password cannot be null or empty.");
                }
                else
                {
                    password = "[ENCRYPTED]_" + value;
                }
            }
        }

        // TODO 4: Balance (Full Property with Validation)
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative. Update ignored.");
                }
                else
                {
                    balance = value;
                }
            }
        //public void Deposit(decimal amount)
        //{
        //    if (amount < 0)
        //    {
        //        Console.WriteLine("Deposit amount cannot be negative.");
        //        return;
        //    }
        //    balance += amount;
        //}
        //public void Withdraw(decimal amount)
        //{
        //    if (amount < 0)
        //    {
        //        Console.WriteLine("Withdrawal amount cannot be negative.");
        //        return;
        //    }
        //    if (amount > balance)
        //    {
        //        Console.WriteLine("Insufficient funds for withdrawal.");
        //        return;
        //    }
        //    balance -= amount;
        }

        // TODO 5: IsVIP (Computed Read-Only)        
        public bool IsVIP
        {
           get
            { 
                if (balance>=100000) return true;
                else return false; 
            }
        }
        // TODO 6: CreatedDate (Get-Only)
        private DateTime createddate=DateTime.Now;
        public DateTime CreatedDate;

        // Constructor
        public UserAccount()
        {
            this.CreatedDate = createddate;
        }
    }
}
