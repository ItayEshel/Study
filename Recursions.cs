using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Recursions
    {
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
            if (n < 2)
                return false;

            if (x * x > n)
                return true;

            if (n % x == 0)
                return false;

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
    }
}