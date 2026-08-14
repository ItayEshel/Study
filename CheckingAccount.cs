using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class CheckingAccount : BasicAccount
    {
        const double DEFAULT_OVERDRAFT = 500;
        private double overDraft;

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string id, double overDraft)
            : base(bankNum, branchNum, accountNum, id)
        {
            this.overDraft = overDraft;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string id) : this(bankNum, branchNum, accountNum, id, CheckingAccount.DEFAULT_OVERDRAFT) { }

        public double GetOverDraft() { return this.overDraft; }

        public void SetOverDraft(int SetOverDraft)
        {
            if(this.overDraft > 0)
            this.overDraft = SetOverDraft;
        }

        public bool Withdrawal(int draw)
        {
            if (draw > 0 && GetBalance() - draw > -overDraft)
            {
                SetBalance(GetBalance() - draw);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "OverDraft " + this.overDraft;
        }

        public override bool AtRisk()
        {
            return GetBalance() < 0;
        }

        public static void UnitTests()
        {
            Console.WriteLine("-------------------------");
            CheckingAccount ca = new CheckingAccount(314, 5125, 55555, "02313");
            Console.WriteLine(ca);
            Console.WriteLine("-------------------------");
            ca.SetOverDraft(5000);
            Console.WriteLine(ca);
            Console.WriteLine("-------------------------");
            Console.WriteLine(ca.Withdrawal(500));
            Console.WriteLine(ca);
            Console.WriteLine("-------------------------");
            Console.WriteLine(ca.Withdrawal(6000));
            Console.WriteLine(ca);
            Console.WriteLine("-------------------------");
            CheckingAccount ca2 = new CheckingAccount(1, 1, 2, "123");
            ca2.SetBalance(-100);
            Console.WriteLine(ca2.AtRisk());

        }
    }
}
