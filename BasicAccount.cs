using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class BasicAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string id;
        private double balance;

        public BasicAccount(int bankNum, int branchNum, int accountNum, string id)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.id = id;
            this.balance = 0;
        }
        public int GetBankNum() { return this.bankNum; }

        public int GetBranchNum() { return this.branchNum; }

        public int GetAccountNum() { return this.accountNum; }

        public string GetId() { return this.id; }

        public double GetBalance() { return this.balance; }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public bool deposit(int deposit)
        {
            if (deposit > 0)
            {
                this.balance += deposit;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "Bank: " + this.bankNum +
                   ", Branch: " + this.branchNum +
                   ", Account: " + this.accountNum +
                   ", ID: " + this.id +
                   ", Balance: " + this.balance;
        }

    }
}
