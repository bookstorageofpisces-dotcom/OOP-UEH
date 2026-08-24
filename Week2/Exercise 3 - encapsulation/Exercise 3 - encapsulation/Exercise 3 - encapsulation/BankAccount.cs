using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Exercise_3___encapsulation
{
    internal class BankAccount
    {
        // TODO 1: Declare private fields (_balance, _pin, _failedAttempts)
        private decimal _balance;
        private string _pin;
        private int _failedAttempts;
        // TODO 2: Declare public AccountHolder property(read-only)
        public string AccountHolder{ get;}
        //TODO 3: Declare IsLocked property with a private setter
        public bool IsLocked
        {
            get
            {
                if (_failedAttempts >= 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            private set;
        }
        // Constructor
        public BankAccount(string accountHolder, decimal initialBalance, string initialPin)
        {
            AccountHolder = accountHolder;
            _balance = initialBalance > 0 ? initialBalance : 0;
            _pin = initialPin;
            _failedAttempts = 0;
            IsLocked = false;
        }
        // TODO 4: Implement Deposit method
        public bool Deposit(decimal amount)
        {
            if (amount >0)
            {
                this._balance += amount;
                Console.WriteLine("Deposit successful:"+amount);
                return true;
            }
            else
            {
                Console.WriteLine("Deposit must be a positive amount.");
                return false;
            }
        }
        // TODO 5: Implement Withdraw method
        public bool Withdraw(decimal amount, string pin)
        {
            if (IsLocked==true)
            {
                Console.WriteLine("Account is locked due to too many failed attempts.");
                return false;
            }
            if (pin == this._pin)
            {
                this._failedAttempts = 0;
                if (amount > 0 && amount <= this._balance)
                {
                    this._balance -= amount;
                    Console.WriteLine("Withdrawal successful");
                    return true;

                }
                else
                {
                    Console.WriteLine("Withdrawal failed");
                    return false;
                }
            }
            else
            {
                this._failedAttempts++;                
                Console.WriteLine("Incorrect PIN."+"(Attempts"+ this._failedAttempts +"/3)"); 
                return false;
            }
        }
        // TODO 6: Implement GetBalance method (PIN required)
        public decimal GetBalance(string inputpin)
        {
            if (inputpin== this._pin)
            {
                return this._balance;
            }
            else
            {
                Console.WriteLine("Error");
                return -1m;
            }
        }
        // TODO 7: Implement ChangePin method
        public bool ChangePin(string currentpin, string newpin)
        {
            if (currentpin == this._pin)
            {
                if (string.IsNullOrEmpty(newpin) || newpin.Length < 4)
                {
                    return false;
                }
                else
                {
                    this._pin = newpin;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

