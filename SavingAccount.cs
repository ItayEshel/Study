using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class SavingAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string id;
        private double balance;
        private Date finishDate;

        public SavingAccount(int bankNum, int branchNum, int accountNum, string id, Date finishDate)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.id = id;
            this.balance = 0;
            this.finishDate = finishDate;
        }

        public int GetBankNum() { return this.bankNum; }

        public int GetBranchNum() { return this.branchNum; }

        public int GetAccountNum() { return this.accountNum; }

        public string GetId() { return this.id; }

        public double GetBalance() { return this.balance; }
        public Date GetFinishDate() { return this.finishDate; }

        public void SetFinishDate(Date Setfinishdate)
        {
            this.finishDate = Setfinishdate;
        }

        public override string ToString()
        {
            return "Bank: " + this.bankNum +
                   ", Branch: " + this.branchNum +
                   ", Account: " + this.accountNum +
                   ", ID: " + this.id +
                   ", Balance: " + this.balance +
                   ", FinishDate " + this.finishDate;
        }

        public bool Deposit(int deposit)
        {
            if (deposit > 0)
            {
                this.balance += deposit;
                return true;
            }

            return false;
        }

        public bool Withdrawal(Date d)
        {

            if (d.CompareTo(this.finishDate) <= 0)
            {
                this.balance = 0;
                return true;
            }
            return false;
        }

        public static void UnitTests()
        {
            Console.WriteLine("-------------------------");
            Date finishdate = new Date(17, 17, 1717);
            SavingAccount sa = new SavingAccount(314, 5125, 55555, "02313", finishdate);
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            sa.SetFinishDate(new Date(20, 2, 2020));
            sa.Deposit(1000);
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            Console.WriteLine(sa.Withdrawal(new Date(1, 1, 1000)));
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            Console.WriteLine(sa.Withdrawal(new Date(20, 2, 2027)));
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");

        }
    }
}
