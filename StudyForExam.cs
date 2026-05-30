using System;
using System.Collections.Generic;
using System.Linq;
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
                        upperCount+= arr[row,col];
                    }

                   if (row > i || row == i && col >= j)
                    {
                        lowerCount+= arr[row,col];
                    }
                }

                
            }

            return upperCount == lowerCount;
        }

        public static int IsEqualUpAndLowCount(int[,] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.GetLength(0)-1; i++)
            {
                for (int j = 0; j < arr.GetLength(1)-1; j++)
                {
                    if (IsEualUpAndLow(arr, i, j))
                    {
                        count++;
                    }
                    
                }
            }

            return count;
        }
    }
}
    
        
    

