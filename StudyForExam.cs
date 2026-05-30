using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class StudyForExam
    {
        public static int Big(int[] arr)
        {
            int max = arr[0], maxi = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxi = i;
                }
            }

            return maxi;
        }

        public static int Junction(int[,] arr, int i, int j)
        {
            int countrow = 0, countcol = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                countcol += arr[row, j];
            }

            for (int col = 0; col < arr.GetLength(1); col++)
            {
                countrow += arr[i, col];
            }

            if (countrow == countcol)
                return 1;

            return 0;
        }

        public static void JunctionCount(int[,] arr)
        {
            int count = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (Junction(arr, row, col) == 1)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        public static bool IsEualUpAndLow(int[,] arr, int i, int j)
        {
            int upperCount = 0;
            int lowerCount = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (row < i || row == i && col <= j)
                    {
                        upperCount += arr[row, col];
                    }

                    if (row > i || row == i && col >= j)
                    {
                        lowerCount += arr[row, col];
                    }
                }


            }

            return upperCount == lowerCount;
        }

        public static int IsEqualUpAndLowCount(int[,] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (IsEualUpAndLow(arr, i, j))
                    {
                        count++;
                    }

                }
            }

            return count;
        }

        public static bool slant(int[,] arr, int i, int j)
        {
            int count = 0;

            if (i + 2 < arr.GetLength(0) && j + 2 < arr.GetLength(1))
            {


                for (int row = i; i < i + 3; i++)
                {
                    for (int col = j; col < j + 3; col++)
                    {
                        if (arr[row, col] == 1)
                        {
                            count++;
                        }
                    }
                }


                if (count == 3)
                {
                    return true;
                }


            }

            return false;


        }

        public static int IsSlant(int[,] arr, int i, int j)
        {
            if (slant(arr, i, j))
            {
                return 1;
            }
            return 0;
        }

        public static int CountSlant(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (IsSlant(arr, i, j) == 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int RepeatingRow(int[,] arr, int k, int j)
        {
            for (int col = j; col < arr.GetLength(1); col++)
            {
                if (arr[k, col] != arr[k + 1, col])
                {
                    return 0;
                }

            }

            return 1;
        }

        public static int IsRepeatingRow(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; i < arr.GetLength(1); j++)
                {
                    if (RepeatingRow(arr, i, j) == 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int PositiveRow(int[,] arr, int k)
        {
           for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[k, i] < 0)
                {
                    return 0;
                }
            }

           return 1;
        }

        public static int PositiveCol(int[,] arr, int j)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
               if (arr[i, j] < 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        public static void IsPoisitiveRow()
        {
            int countProw = 0, countPcol = 0;
            int[,] arr = new int[45, 42];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (PositiveRow(arr, i) == 1)
                    {
                        countProw++;
                    }
                    if (PositiveCol(arr, j) == 1)
                    {
                        countPcol++;
                    }
                }
            }

            if (countProw > countPcol)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        //public bool IsGlowSquare(int i, int j)
        //{
        //    int sum = 0;
        //    for (int row = i; row < i + 3; row++)
        //    {
        //        for (int col = j; col < j + 3; col++)
        //        {
        //            sum += this.matrix[row, col];
        //        }
        //    }

        //    return (sum > this.num);

        //}

        //public int GlowSqaureCount()
        //{
        //   int count = 0;

        //    for (int row = 0; row < this.matrix.GetLength(0)-2; row++)
        //    {
        //        for (int col = 0; col < this.matrix.GetLength(1)-2; col++)
        //        {
        //            if (IsGlowSquare(row, col))
        //            {
        //                count++;
        //            }
        //        }
        //    }

        //    return count;
        //}

        public static int Place(int[,] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == x)
                    {
                        return count;
                    }
                    count++;
                }
            }

            return -1;
        }

        public static bool IsDouble(string str)
        {
            if (str.Length % 2 != 0)
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length / 2])
                {
                    return false;
                }
            }

            return true;
        }
    }
}








