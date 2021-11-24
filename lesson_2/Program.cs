using System;
using System.Collections.Generic;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(210901);
            BankAccount account2 = new BankAccount(TypeOfBankAccount.CREDIT);
            BankAccount account3 = new BankAccount(250102, TypeOfBankAccount.DEPOSIT);

            account1.InfoBankAccount();
            account2.InfoBankAccount();
            account3.InfoBankAccount();
        }
    }
    public enum TypeOfBankAccount
    {
        DEBIT,
        CREDIT,
        DEPOSIT,
        BUDGET
    }
    public class BankAccount
    {
        int _number;

        int _balance;

        TypeOfBankAccount _typeAccount;

        public BankAccount()
        {
            _number = RND();
        }

        public BankAccount(int balance)
        {
            _balance = balance;
            _number = RND();

        }
        public BankAccount(TypeOfBankAccount typeAccount)
        {
            _typeAccount = typeAccount;
            _number = RND();

        }

        public BankAccount(int balance, TypeOfBankAccount typeAccount)
        {
            _balance = balance;
            _typeAccount = typeAccount;
            _number = RND();

        }

        int RND()
        {
            Random rnd = new Random();
            _number = rnd.Next(1000000000, int.MaxValue);
            return _number;
        }
       
        public int InfoNumber()
        {
            return _number;
        }

        public int InfoBalance()
        {
            return _balance;
        }

        public TypeOfBankAccount InfoTypeAccount()
        {
            return _typeAccount;
        }

        public void InfoBankAccount()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}");
        }
    }
}