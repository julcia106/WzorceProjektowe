// Julia Rutkowska - lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace labs
{
    class Builder
    {
        static void Main(string[] args)
        {
            new Lab4Builder().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }

    class Lab4Builder : Lab
    {
        public void Run()
        {
            BankAccountBuilder builder = new BankAccountBuilder();
            var account = builder.addAccountNumber(123123123).addHolder("Henryk Kwinto").addBalace(20).getResult();
            Console.WriteLine(account.getAccountDescription());
        }
    }


    class BankAccountBuilder
    {
        int AccountNumber { get; set; }
        string Holder { get; set; }
        double Balance { get; set; }

        public BankAccountBuilder addAccountNumber(int number)
        {
            AccountNumber = number;
            return this;
        }

        public BankAccountBuilder addHolder(string holder)
        {
            Holder = holder;
            return this;
        }

        public BankAccountBuilder addBalace(double balance)
        {
            Balance = balance;
            return this;
        }

        public BankAccount getResult()
        {
            return (new BankAccount(AccountNumber, Holder, Balance));
        }
    }   
    class BankAccount
    {
        private int accountNumber;
        private string holder;
        private double balance;

        public BankAccount(int accountNumber, string holder, double balance)
        {
            this.accountNumber = accountNumber;
            this.holder = holder;
            this.balance = balance;
        }

        public String getAccountDescription()
        {
            return "Account number: " + accountNumber + "\tHolder: " + holder + "\tBalance: " + balance;
        }
    }
}