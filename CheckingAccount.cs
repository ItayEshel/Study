using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class CheckingAccount
    {

        const double DEFAULT_OVERDRAFT = 500;
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string id;
        private double balance;
        private double overDraft;

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string id, double overDraft)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.id = id;
            this.balance = 0;
            this.overDraft = DEFAULT_OVERDRAFT;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string id) : this(bankNum, branchNum, accountNum, id, CheckingAccount.DEFAULT_OVERDRAFT) { }

        public int GetBankNum() { return this.bankNum; }

        public int GetBranchNum() { return this.branchNum; }

        public int GetAccountNum() { return this.accountNum; }

        public string GetId() { return this.id; }

        public double GetBalance() { return this.balance; }

        public double GetOverDraft() { return this.overDraft; }
    }
}
