using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class BusinessAccount : BasicAccount
    {
        private string businessName;
        private double overDraft;
        public BusinessAccount(int bankNum, int branchNum, int accountNum, string id, string businessName, double overDraft)
            : base(bankNum, branchNum, accountNum, id)
        {
            this.businessName = businessName;
            this.overDraft = overDraft;
        }

        public string GetBusinessName()
        {
            return this.businessName;
        }
          
        public void SetBusinessName(string businessName)
        {
            this.businessName=businessName;
        }

        public void SetOverDraft(double overDraft)
        {
            if (overDraft > 0)
                this.overDraft = overDraft;
        }
        public bool Deposit(int deposit)
        {
            if (deposit > 0)
            {
                SetBalance(GetBalance() + deposit);
                return true;
            }

            return false;
        }
        public bool SalaryToAcc(int amount)
        {
            if (amount > 0 && GetBalance() - amount >= -overDraft)
            {
                SetBalance(GetBalance() - amount);
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return base.ToString() +
                   ", Business Name: " + this.businessName +
                   ", Overdraft: " + this.overDraft;
        }

        public static void UnitTests()
        {
            BusinessAccount ba = new BusinessAccount(1, 2, 12345, "999999999", "Itay", 5000);
            Console.WriteLine(ba);
            ba.Deposit(1000);
            Console.WriteLine(ba);
            Console.WriteLine(ba.SalaryToAcc(3000));
            Console.WriteLine(ba);
            Console.WriteLine(ba.SalaryToAcc(10000));   
            Console.WriteLine(ba);
        }
    }
}
