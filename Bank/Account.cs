using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bank
    {
    class Account
        {
        public int Acc_Number { get; private set; }
        public double Amount { get; private set; }

        public string Name { get; set; }

        public Account(string name, int accountnumber)
            {
            Acc_Number = accountnumber;
            Name = name;
            }

        public Account(string name, int accountnumber, double amount) : this(name , accountnumber)
            {
            Name = name;
            Acc_Number = accountnumber;
            Amount = amount;
            
            }

        public void Deposit (double amount)
            {
             Amount += amount;
            }

        public void Take (double take)
            {
            Amount -= 5.00;
            Amount -= take;
            }

        public override string ToString()
            {
            return $" Account: {Acc_Number}, Name: {Name}, Amount: ${Amount.ToString("F2", CultureInfo.InvariantCulture)} ";
            }

        }
    }