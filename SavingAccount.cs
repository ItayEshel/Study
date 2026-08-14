using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class SavingAccount : BasicAccount
    {
        private Date finishDate;

        public SavingAccount(int bankNum, int branchNum, int accountNum, string id, Date finishDate)
            : base(bankNum, branchNum, accountNum, id)
        {
            this.finishDate = finishDate;
        }

        public Date GetFinishDate() { return this.finishDate; }

        public void SetFinishDate(Date Setfinishdate)
        {
            this.finishDate = Setfinishdate;
        }

        public bool Withdrawal(Date d)
        {

            if (d.CompareTo(this.finishDate) <= 0)
            {
                SetBalance(0);
                return true;
            }
            return false;
        }

        public override bool AtRisk()
        {
            return GetBalance() == 0;
        }

        public override string ToString()
        {
            return base.ToString() + " FinishDate " + this.finishDate;
        }

        public static void UnitTests()
        {
            Console.WriteLine("-------------------------");
            Date finishdate = new Date(17, 17, 1717);
            SavingAccount sa = new SavingAccount(314, 5125, 55555, "02313", finishdate);
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            sa.SetFinishDate(new Date(20, 2, 2020));
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            Console.WriteLine(sa.Withdrawal(new Date(1, 1, 1000)));
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            Console.WriteLine(sa.Withdrawal(new Date(20, 2, 2027)));
            Console.WriteLine(sa);
            Console.WriteLine("-------------------------");
            DateTime finishDate = new DateTime(2026, 12, 31);
            SavingAccount sa2 = new SavingAccount(1, 1, 3, "123",finishdate);
            sa2.SetBalance(0);
            Console.WriteLine(sa2.AtRisk());

        }
    }
}
