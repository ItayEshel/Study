using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class BankServices
    {
        BasicAccount[] accNum;

        public BankServices(int length)
        {
            this.accNum = new BasicAccount[length];
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

        public SavingAccount[] ZeroSavings()
        {
            int count = 0;

            for (int i = 0; i < this.accNum.Length; i++)
            {
                if (accNum[i] is SavingAccount)
                {
                    if (accNum[i].GetBalance() == 0)
                    {
                        count++;
                    }
                }
            }

            SavingAccount[] arr = new SavingAccount[count];
            int p = 0;
            for (int i = 0; i < this.accNum.Length; i++)
            {
                if (accNum[i] is SavingAccount)
                {
                    if (accNum[i].GetBalance() == 0)
                    {
                        arr[p] = (SavingAccount)accNum[i];
                        p++;
                    }
                }
            }

            return arr;
        }


        public string[] LoanSuggestions()
        {
            int count = 0;

            for (int i = 0; i < this.accNum.Length; i++)
            {
                if (accNum[i] is CheckingAccount)
                {
                    if (((CheckingAccount)accNum[i]).GetOverDraft() / 2 < accNum[i].GetBalance() && accNum[i].GetBalance() < 0)
                    {
                        count++;
                    }
                }
            }

            string[] arr = new string[count];
            int p = 0;

            for (int i = 0; i < this.accNum.Length; i++)
            {
                if (accNum[i] is CheckingAccount)
                {
                    if (((CheckingAccount)accNum[i]).GetOverDraft() / 2 < accNum[i].GetBalance() && accNum[i].GetBalance() < 0)
                    {
                       if (accNum[i] is BusinessAccount)
                        {
                            arr[p] = "Type: BusinessAccount" + accNum[i].ToString();
                        }
                       else
                        {
                            arr[p] = "Type: CheckingAccount" + accNum[i].ToString();
                        }

                        p++;
                    }
                }
                
            }

            return arr;
        }
        public static void UnitTests()
        {
            BasicAccount[] arr = new BasicAccount[2];
            BankServices bank = new BankServices(5);
            BasicAccount acc = new BasicAccount(1, 1, 2, "456");
            Console.WriteLine(bank.Add(acc));

            Console.WriteLine("-----------------------------");
            BasicAccount[] arr2 = new BasicAccount[2];
            BankServices bank2 = new BankServices(4);
            Console.WriteLine(PrintArray.PrintArrays(bank.GetAccNum()));

            Console.WriteLine("-----------------------------");
            BasicAccount[] arr3 = new BasicAccount[2];
            BasicAccount[] newArr = new BasicAccount[3];
            BankServices bank3 = new BankServices(1);
            bank3.SetAccNum(newArr);
            Console.WriteLine(bank3.GetAccNum().Length);

            Console.WriteLine("-----------------------------");
            BasicAccount acc2 = new BasicAccount(1, 1, 5, "123");
            BasicAccount[] arr4 = { acc2 };
            BankServices bank4 = new BankServices(3);
            Console.WriteLine(bank4.AccDetails(5));

            Console.WriteLine("-----------------------------");
            BasicAccount acc3 = new BasicAccount(1, 1, 1, "123");
            BasicAccount[] arr5 = { acc3 };
            BankServices bank5 = new BankServices(4);
            Console.WriteLine(bank5.NumAcc("123"));

            Console.WriteLine("-----------------------------");
            BasicAccount acc4 = new BasicAccount(1, 1, 1, "123");

            BankServices bank6 = new BankServices(5);
            bank6.Add(acc4);
            BasicAccount[] result = bank6.AccById("123");
            Console.WriteLine(result[0]);

            Console.WriteLine("-----------------------------");
            BasicAccount acc1 = new BasicAccount(1, 1, 1, "111");
            BasicAccount[] arr7 = { acc1 };
            BankServices bank7 = new BankServices(7);
            BasicAccount[] result2 = bank.RiskAccounts();
            Console.WriteLine(result.Length);

            Console.WriteLine("-----------------------------");
            BankServices bankServices = new BankServices(6);

            BasicAccount basicAcc = new BasicAccount(100, 10, 1, "123456789");
            CheckingAccount checkingAcc = new CheckingAccount(10, 17, 17817, "123456789", 600);
            BusinessAccount businessAcc = new BusinessAccount(178, 84, 3301951, "8765432", "A Business", 23);

            Date endDate = new Date(17, 12, 2020);
            SavingAccount savingAcc = new SavingAccount(1, 11, 111, "1111", endDate);
            SavingAccount savingAcc2 = new SavingAccount(2, 22, 222, "2222", endDate);
            SavingAccount savingAcc3 = new SavingAccount(3, 33, 333, "3333", endDate);

            basicAcc.SetBalance(0);
            savingAcc.SetBalance(0);
            savingAcc2.SetBalance(200);
            savingAcc3.SetBalance(0);

            bankServices.Add(basicAcc);
            bankServices.Add(checkingAcc);
            bankServices.Add(businessAcc);
            bankServices.Add(savingAcc);
            bankServices.Add(savingAcc2);
            bankServices.Add(savingAcc3);

            SavingAccount[] savingAccounts = bankServices.ZeroSavings();

            for (int i = 0; i < savingAccounts.Length; i++)
            {
                Console.WriteLine(savingAccounts[i]);
            }

        }
    }
    
}
