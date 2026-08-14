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
                if (accNum[i] != null && accNum[i].GetAccountNum() == num)
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
                if (accNum[i] != null && accNum[i].GetId() == num)
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
                if (accNum[i] != null && accNum[i].GetId() == id)
                {
                    count++;
                }
            }

            BasicAccount[] acc = new BasicAccount[count];
            int j = 0;

            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i] != null && accNum[i].GetId() == id)
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
            double Max = 0;

            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i] != null)
                {
                    string id = accNum[i].GetId();
                    double sum = 0;

                    for (int j = 0; j < accNum.Length; j++)
                    {
                        if (accNum[j] != null && accNum[j].GetId() == id)
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
            }

            return maxId;
        }

        public BasicAccount[] RiskAccounts()
        {
            int count = 0;
            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i] != null && accNum[i].AtRisk())
                {
                    count++;
                }
            }
            BasicAccount[] risk = new BasicAccount[count];
            int j = 0;

            for (int i = 0; i < accNum.Length; i++)
            {
                if (accNum[i] != null && accNum[i].AtRisk())
                {
                    risk[j] = accNum[i];
                    j++;
                }
            }

            return risk;
        }

        public static void UnitTests()
        {
            BasicAccount[] arr = new BasicAccount[2];
            BankServices bank = new BankServices(1, 1, 1, "123", arr);
            BasicAccount acc = new BasicAccount(1, 1, 2, "456");
            Console.WriteLine(bank.Add(acc));

            Console.WriteLine("-----------------------------");
            BasicAccount[] arr2 = new BasicAccount[2];
            BankServices bank2 = new BankServices(1, 1, 1, "123", arr);
            Console.WriteLine(PrintArray.PrintArrays(bank.GetAccNum()));

            Console.WriteLine("-----------------------------");
            BasicAccount[] arr3 = new BasicAccount[2];
            BasicAccount[] newArr = new BasicAccount[3];
            BankServices bank3 = new BankServices(1, 1, 1, "123", arr3);
            bank3.SetAccNum(newArr);
            Console.WriteLine(bank3.GetAccNum().Length);

            Console.WriteLine("-----------------------------");
            BasicAccount acc2 = new BasicAccount(1, 1, 5, "123");
            BasicAccount[] arr4 = { acc2 };
            BankServices bank4 = new BankServices(1, 1, 1, "123", arr4);
            Console.WriteLine(bank4.AccDetails(5));

            Console.WriteLine("-----------------------------");
            BasicAccount acc3 = new BasicAccount(1, 1, 1, "123");
            BasicAccount[] arr5 = { acc3 };
            BankServices bank5 = new BankServices(1, 1, 1, "123", arr5);
            Console.WriteLine(bank5.NumAcc("123"));

            Console.WriteLine("-----------------------------");
            BasicAccount acc4 = new BasicAccount(1, 1, 1, "123");
            BasicAccount[] arr6 = { acc4 };
            BankServices bank6 = new BankServices(1, 1, 1, "123", arr6);
            BasicAccount[] result = bank6.AccById("123");
            Console.WriteLine(result[0]);

            Console.WriteLine("-----------------------------");
            BasicAccount acc1 = new BasicAccount(1, 1, 1, "111");
            BasicAccount[] arr7 = { acc1 };
            BankServices bank7 = new BankServices(1, 1, 1, "123", arr);
            BasicAccount[] result2 = bank.RiskAccounts();
            Console.WriteLine(result.Length);
        }
    }
    
}
