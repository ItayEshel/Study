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

        public int GetBankNum() { return this.bankNum; }

        public int GetBranchNum() { return this.branchNum; }

        public int GetAccountNum() { return this.accountNum; }

        public string GetId() { return this.id; }

        public double GetBalance() { return this.balance; }

        public bool deposit(int deposit)
        {
            if (deposit > 0)
            {
                this.balance += deposit;
                return true;
            }

            return false;
        }


    }
}
