using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class BankServices : BasicAccount
    {
        BasicAccount[] accNum;

        public BankServices(int bankNum, int branchNum, int accountNum, string id, BasicAccount[] accNum)
            : base(bankNum, branchNum, accountNum, id)
        {
            this.accNum = accNum;
        }

        public BasicAccount[] GetAccNum()
        {
            return this.accNum;
        }

        public void SetAccNum(BasicAccount[] accNum)
        {
            this.accNum = accNum;
        }

        public bool Add(BasicAccount acc)
        {
            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i] == null)
                {
                    accNum[i] = acc;
                    return true;
                }
            }

            return false;
        }

        public string AccDetails(int num)
        {
            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i].GetAccountNum() == num)
                {
                    return accNum[i].ToString();
                }

            }

            return " ";
        }


        public int NumAcc(string num)
        {
          int count = 0;

            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i].GetId() == num)
                {
                    count++;
                }

            }

            return count;
        }

        public BasicAccount[] AccById(string id)
        {
            int count = 0;
            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i].GetId() == id)
                {
                    count++;
                }
            }

            BasicAccount[] acc = new BasicAccount[count];
            int j = 0;

            for (int i = 0; j < accNum.Length; i++)
            {
                if (accNum[i].GetId() == id)
                {
                    acc[j] = accNum[i];
                    j++;
                }
            }

            return acc;
        }

        public string RichestCustomer()
        {
            string maxId = "";
            double sum = 0;
            double Max = 0;
            string id = "";

            for (int i = 0; i < accNum.Length; i++)
            {
                id = accNum[i].GetId();
                sum = 0;
                    
                for (int j = 0; j < accNum.Length; j++)
                {
                    if (accNum[i].GetId() == id)
                    {
                        sum += accNum[j].GetBalance();
                    }
                }

                if (sum > Max)
                {
                    Max = sum;
                    maxId = id;
                }
            }

            return maxId;
        }
    }
}
