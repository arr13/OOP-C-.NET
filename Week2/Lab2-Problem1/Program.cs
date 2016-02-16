using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal anualInterestRate = 7;
            decimal balance = 1500;
            uint yearCreated = 2004;
            uint id = 1897856;
            Account account = new Account(anualInterestRate, balance, yearCreated, id);

            decimal withdraw = 52;
            account.Withdraw(withdraw);
            account.ShowBalance();

            decimal deposit = 52;
            account.Deposit(deposit);
            account.ShowBalance();
        }
    }
}
