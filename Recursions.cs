using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Recursions
    {
        public static void UnitTests()
        {
            //int n = PositiveSum(5);
            //Console.WriteLine(n);

            //int n = Factorial(5);
            //Console.WriteLine(n);

            //int n = OddMult(7);
            //Console.WriteLine(n);

            //int n = NumLength(12345);
            //Console.WriteLine(n);

            //int n = Divide(17, 5);
            //Console.WriteLine(n);

            //int n = Divide2(17, 5);
            //Console.WriteLine(n);

            //bool n = IsMultiple(10, 5);
            //Console.WriteLine(n);
            //bool n2 = IsMultiple(10, 6);
            //Console.WriteLine(n2);

            //bool n = IsPrimeNumber(7);
            //bool n1 = IsPrimeNumber(10);
            //bool n2 = IsPrimeNumber(2);
            //bool n3 = IsPrimeNumber(1);
            //Console.WriteLine(n);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);

            //bool n = IsEvenOrOdd(1111);
            //bool n2 = IsEvenOrOdd(1234);
            //bool n3 = IsEvenOrOdd(2222);
            //Console.WriteLine(n);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);

            //int n = sum(5);
            //Console.WriteLine(n);

            //double n = PrimeSum(10);
            //Console.WriteLine(n);
            //double n2 = PrimeSum(6);
            //Console.WriteLine(n2);

            //int n = SumMult(3, 10);
            //int n2 = SumMult(5, 21);
            //Console.WriteLine(n);
            //Console.WriteLine(n2);

            int n = TwoPowSum(5);
            Console.WriteLine(n);
            int n2 = TwoPowSum(6);
            Console.WriteLine(n2);
        }

        public static int PositiveSum(int n)
        {
            if (n == 1)
                return 1;

            else
            {
                int result = n + PositiveSum(n - 1);
                return result;
            }
        }

        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;

            else
            {
                int result = n * Factorial(n - 1);
                return result;
            }
        }

        public static int OddMult(int n)
        {
            if (n == 1)
                return 1;

            else 
            {
                if (n % 2 == 0)
                {
                   return OddMult(n - 1);
                }
            }

            return n * OddMult(n - 2);
        }

        public static int NumLength(int n)
        {
            if (n < 10)
                return 1;

            else
            {
                int count = 1 + NumLength(n / 10);
                return count;
            }
        }

        public static int Divide(int n1, int n2)
        {
            if (n1 < n2)
                return 0;

            else
            {
                int result = 1 + Divide(n1 - n2, n2);
                return result;
            }
        }

        public static int Divide2(int n1, int n2)
        {
            if (n1 < n2)
                return n1;

            else
            {
                int result = Divide2(n1 - n2, n2);
                return result;
            }
        }

        public static bool IsMultiple(int x, int y)
        {
            if (x == y)
                return true;

            if (x < y)
                return false;

            return IsMultiple(x - y, y);
        }

        public static bool IsPrimeNumber(int n , int x = 2)
        {
            if (x == n)
            {
                return true;
            }

            if (n % x == 0 || n == 1)
            {
                return false;
            }

            return IsPrimeNumber(n, x + 1);
        }

        public static bool IsEvenOrOdd(int n)
        {
            Math.Abs(n);

            if (n < 10)
                return true;

            int digit1 = n % 10;
            int digit2 = (n / 10) % 10;

            if (digit1 % 2 != digit2 % 2)
            {
                return false;
            }

            return IsEvenOrOdd(n / 10);
        }

       public static int sum(int n)
        {
            if (n == 1)
            {
                return 2;
            }

            if (n % 2 == 0)
            {
                return n * n + sum(n - 1);
            }

            return n * 2 + sum(n - 1);
        }

        public static double PrimeSum(int n)
        {
            if (n == 1)
                return 1;

            if (n % 2 == 1)
            {
              return 4 * (n / 2) + 1 + sum(n - 1);
            }

            return -Math.Sqrt(4 * (n / 2) -1) + sum(n - 1);
        }

        static int SumMult(int n1, int n2)
        {
            return SumMult(n1, n2, n1);
        }

        static int SumMult(int n1, int n2, int current)
        {
            if (current >= n2)
                return 0;

            return current + SumMult(n1, n2, current + n1);
        }

        static int TwoPowSum(int n)
        {
            if (n == 1)
                return 0;

            if (n == 2)
                return 1;

            return TwoPowSum(n-1) * TwoPowSum(n-1) + TwoPowSum(n - 2) * TwoPowSum(n - 2);
        }

        
        //////////////////////////////////////////// ARRAYS RECURSION ///////////////////////////////////////////////


        public static int SumArr(int[] arr, int i)
        {
            if (i == 0)
                return arr[i];

            return arr[i] + SumArr(arr, i - 1);
        }

        public static int PosInArr(int[] arr, int i)
        {
            if (i < 0)
            {
                return 0;
            }
            if (arr[i] > 0)
            {
                return 1 + PosInArr(arr, i - 1);
            }

            return PosInArr(arr, i - 1);
            
        }

        public static int NumIndex(int[] arr, int num, int i = 0)
        {
            if (i >= arr.Length)
            {
                return -1;
            }
            if (num == arr[i])
            {
                return i;
            }

            return NumIndex(arr, num, i + 1);
        }

        public static bool UpOrder(int[] arr, int i = 1)
        {
            if (i >= arr.Length)
            {
                return false;
            }

            if (arr[i] < arr[i - 1])
            {
                return false;
            }

            if (i == arr.Length - 1)
            {
                return true;
            }

            return UpOrder(arr, i + 1);
        }

        public static bool IsAllPrime(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
            {
                return true;
            }

            if (IsPrimeNumber(arr[i]) == false)
            {
                return false;
            }

            if (i == arr.Length - 1)
            {
                return true;
            }

            return IsAllPrime(arr, i);
        }

        public static bool IsNumInRow(int[,] arr, int row, int n)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[row,i] == n)
                {
                    return true;
                }
            }

            return false;
        }

        public static int HowManyRows(int[,] arr, int n, int i)
        {
            if (i > arr.GetLength(0))
            {
                return 0;
            }

            if (i < 0)
            {
                return 0;
            }

            if (IsNumInRow(arr, i, n))
            {
                return 1 + HowManyRows(arr, n, i - 1);
            }

            return HowManyRows(arr, n, i - 1);


        }

        public static bool IsPolindrome(int[] arr)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, arr.Length - 1);
            int y = rnd.Next(x, arr.Length);
            return IsPolindrome(arr,y,x);
        }

        public static bool IsPolindrome(int[] arr, int y, int x)
        {
            if(y >= x)
            {
                return true;
            }
            else if (arr[y] == arr[x])
            {
                return IsPolindrome(arr, y + 1, x - 1);
            }
            return false;
        }

        private static int HowManyLowerLettles(string s, int i=0)
        {
            if (i >= s.Length)
            {
                return 0;
            }
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                return 1 + HowManyLowerLettles(s, i + 1);
            }

            return HowManyLowerLettles(s, i + 1);
        }

        public static string StarAfterThree(string s, int i =3)
        {
            if (i >= s.Length)
            {
                return s;
            }

            string substring1 = s.Substring(0, i);
            string substring2 = s.Substring(i);

            return (StarAfterThree(substring1 + "*" + substring2, i + 4));

        }

        public static string ReverseString(string s)
        {
            int i = s.Length - 1;
            return ReverseString(s, "", i);
        }

        private static string ReverseString(string s, string s2, int i)
        {
            if (i < 0)
            {
                return s2;
            }
            s2 = s2 + s[i];
            return ReverseString(s, s2, i - 1);
                
        }



        public static void UnitTests2()
        {
            //int[] arr = { 2, 2, 2 };
            //Console.WriteLine(SumArr(arr , 2));

            //int[] arr = { 2, -4, 5,-3 };
            //Console.WriteLine(PosInArr(arr , 3));

            //int[] arr = { 2, -4, 5, -3 };
            //Console.WriteLine(NumIndex(arr, 54, 4));

            //int[] arr = { 1, 2, -1, 4, 5 };
            //Console.WriteLine(UpOrder(arr, 1));

            //int[] arr = {62, 24 };
            //Console.WriteLine(IsAllPrime(arr, 0));

            //int n = 5;
            //int[,] arr = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 0, 2, 4, 1, 1 }, { 5, 3, 2, 1, 0 } };
            //Console.WriteLine(HowManyRows(arr, n, 3));

            //int[] arr = { 1, 2, 3, 3, 2, 1 };
            //Console.WriteLine(IsPolindrome(arr));

            //string s = "abcASD";
            //Console.WriteLine(HowManyLowerLettles(s,0));

            //string s = "asdzxcasd";
            //Console.WriteLine(StarAfterThree(s,3));

            string s = "idodo";
            Console.WriteLine(ReverseString(s));
        }


        /////////////////////////////////// Recursions Void ///////////////////////////////////////////
        
        public static void BetweenTwoLetters(char tav1, char tav2)
        {
            if (tav1 == tav2)
            {
                Console.WriteLine("same letter");
            }

            else if (tav1 < tav2)
            {
                Console.WriteLine(tav1 + 1);
                BetweenTwoLetters((char)(tav1 + 1), tav2);
            }

            else
            {
                Console.WriteLine(tav2 + 1);
                BetweenTwoLetters(tav1, (char)(tav2 + 1));
            }
        }

        public static void UnitTests3()
        {
            BetweenTwoLetters('a', 'd');

        }
    }
}