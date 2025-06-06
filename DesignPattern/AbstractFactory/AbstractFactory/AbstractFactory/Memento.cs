using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    class BankMemento
    {
        public int Balance { get; set; }

        public BankMemento(int balance)
        {
            Balance = balance;
        }

    }

    interface IBackAccountService
    {
        BankMemento Deposit(int amount);
        void Restore(BankMemento state);
    }

    class BackAccountService : IBackAccountService
    {
        private int Balance { get; set; }

        //اضافه کردن به حساب
        public BankMemento Deposit(int amount)
        {
            var state = new BankMemento(amount);

            Balance += amount;

            return state;
        }

        public void Restore(BankMemento state)
        {
            Balance = state.Balance;
        }

        public int GetBalance() => Balance;
    }
}
