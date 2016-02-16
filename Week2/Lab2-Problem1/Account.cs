using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Problem1
{
    public class Account
    {
        private decimal anualInterestRate;
        private decimal balance;
        private uint yearCreated;
        private uint id;

        public Account()
        {

        }

        public Account(decimal anualInterestRate, decimal balance, uint yearCreated, uint id)
        {
            AnualInterestRate = anualInterestRate;
            Balance = balance;
            YearCreated = yearCreated;
            Id = id;
        }

        public decimal AnualInterestRate
        {
            get
            {
                return anualInterestRate;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    anualInterestRate = value;
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        public uint YearCreated
        {
            get
            {
                return yearCreated;
            }
            set
            {
                if (value >= 1900 && value <= 2015)
                {
                    yearCreated = value;
                }
            }
        }

        public uint Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value >= 10000000 && value <= 99999999)
                {
                    id = value;
                }
            }
        }

        public void Deposit(decimal deposit)
        {
            decimal currentBalance = Balance;
            Balance = deposit;
            currentBalance += Balance;
            Balance = currentBalance;
        }

        public void Withdraw(decimal money)
        {
            if (money > Balance)
            {
                Console.WriteLine("There isn`t enougth money!");
            }
            else
            {
                decimal currentBalance = Balance;
                currentBalance -= money;
                Balance = currentBalance;
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}
