using System;
using System.Collections.Generic;
using System.Text;

namespace Pr11_SimpleBank
{
    public class BankAccount
    {
        private string _name = String.Empty;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private double _balance;
        public double Balance => _balance;
        private bool _locked;

        // Main constructor with 3 parameters, being called by the other 2
        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            _balance = balance;
            _locked = locked;
        }

        // Constructor with 2 parameters, which calls the one with 3
        public BankAccount(string name, double balance) : this(name, balance, false)
        {
        }
        
        // Constructor with 1 parameter, which calls the one with 3
        public BankAccount(double balance) : this(String.Empty, balance, false)
        {
        }

        public void Deposit(double amount)
        {
            if (!_locked)
                _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (!_locked && amount <= _balance)
                _balance -= amount;
        }

        public void ChangeLockState()
        {
            if (_locked)
                _locked = false;
            else
                _locked = true;
        }

        // Override the ToString() method
        public override string ToString()
        {
            return $"Name: {Name}, Balance: {Balance}";
        }

    }
}

