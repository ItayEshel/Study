using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{

    public class IntNode
    {
        private int value;
        private IntNode next;

        public static string PrintIntNode(IntNode n1)
        {
            string s = "[";
            for (IntNode tmp = n1; tmp != null; tmp = tmp.GetNext())
            {
                s += tmp;
                if (tmp.GetNext() != null)
                    s += ",";
            }
            return s + "]";
        }
        public IntNode(int value)
        {
            this.value = value;
            this.next = null;
        }
        public IntNode(int value, IntNode next)
        {
            this.value = value;
            this.next = next;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetValue(int value) { this.value = value; }

        public IntNode GetNext()
        {
            return this.next;
        }
        public void SetNext(IntNode next) { this.next = next; }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public static int Sum(IntNode l)
        {
            int sum = 0;
            
            while (l != null)
            {
                sum += l.GetValue();
                l=l.GetNext();
            }

            return sum;
        }

        public static int Odd(IntNode l)
        {
            int count = 0;

            while (l != null)
            {
                if (l.GetValue() % 2 == 1)
                {
                    count++;
                }

                l = l.GetNext();
            }

            return count;
        }

        public static int EvenAndOddDiff(IntNode l)
        {
            int oddDiff = 0, evenDiff = 0;

            while (l != null)
            {
                if (l.GetValue() % 2 == 0)
                {
                    evenDiff+= l.GetValue();
                }
                else
                {
                    oddDiff += l.GetValue();
                }

                l = l.GetNext();
            }

            return Math.Abs(oddDiff - evenDiff);
            
        }

        public static bool PosBiggerThanNeg(IntNode l)
        {
            int posCount = 0, negCount = 0;

            while (l != null)
            {
                if (l.GetValue() > 0)
                {
                    posCount++;
                }
                else
                {
                    negCount++;
                }

                l = l.GetNext();
            }

            if (posCount >= negCount)
                return true;

            return false;

        }

        public static bool IsInList(IntNode l, int x)
        {
            while (l != null)
            {
                if (l.GetValue() == x)
                {
                    return true;
                }

                l = l.GetNext();
            }

            return false;
        }

        public static bool IsGoingDown(IntNode l)
        {
            int current = l.GetValue();
            l = l.GetNext();

            while (l != null)
            {
                if (l.GetValue() > current)
                {
                    return false;
                }

                current = l.GetValue();
                l = l.GetNext();
            }

            return true;
        }
        
        public static void UnitTest()
        {
            //IntNode end = new IntNode(51); //3
            //IntNode n2 = new IntNode(3, end); //2
            //IntNode head = new IntNode(42, n2); //1

            //end = null;
            //n2 = null;

            //IntNode temp = head;
            //while (true)
            //{
            //    if (temp.GetNext() == null)
            //    {
            //        temp.SetNext(new IntNode(99));
            //        break;
            //    }
            //    temp = temp.GetNext();

            //}

            ////--------------------------------------
            //IntNode temp2 = head;
            //while (temp2 != null)
            //{
            //    Console.WriteLine(temp2);
            //    temp2 = temp2.GetNext();
            //}

            ////--------------------------------------
            //IntNode temp3 = head;
            //while (temp3.GetNext().GetNext() != null)
            //{
            //    temp3 = temp3.GetNext();
            //}
            //temp3.SetNext(null);

            //temp3 = head;
            //while (temp3 != null)
            //{
            //    Console.WriteLine(temp3);
            //    temp3 = temp3.GetNext();
            //}
            //--------------------------------------

            //IntNode T1 = new IntNode(1, new IntNode(2, new IntNode(3)));
            //Console.WriteLine(Sum(T1));
            //IntNode T1 = new IntNode(1, new IntNode(2, new IntNode(3)));
            //Console.WriteLine(Odd(T1));
            //IntNode T1 = new IntNode(1, new IntNode(2, new IntNode(3,new IntNode(4))));
            //Console.WriteLine((EvenAndOddDiff(T1)));
            //IntNode T1 = new IntNode(-1, new IntNode(-2, new IntNode(-3,new IntNode(4))));
            //Console.WriteLine(PosBiggerThanNeg(T1));
            //IntNode T1 = new IntNode(-1, new IntNode(-2, new IntNode(-3,new IntNode(4))));
            //int x = 12;
            //Console.WriteLine(IsInList(T1,x));
            //IntNode T1 = new IntNode(4, new IntNode(2, new IntNode(0, new IntNode(1))));
            //Console.WriteLine(IsGoingDown(T1));

        }
    }
}


    

