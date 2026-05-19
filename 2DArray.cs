using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class _2DArray
    {
        // 2015:

        //public bool IsEven(int k, int j)
        //{
        //    for (int i = k; i < this.matrix.GetLength(0); i++)
        //    {
        //        for (int col = j; col < this.matrix.GetLength(1); col++)
        //        {
        //            if (this.matrix[i, col] % 2 != 0)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        //public static void()
        //{
        //    int rows = int.Parse(Console.ReadLine());
        //    int cols = int.Parse(Console.ReadLine());
        //    Stam s = new Stam(rows, cols);

        //    Console.WriteLine("Enter index row:");
        //    int rowI = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter index col:");
        //    int colI = int.Parse(Console.ReadLine());
        //    if (s.IsEven(rowI, colI))
        //    {
        //        Console.WriteLine("The sub-matrix is even.");
        //    }
        //}

        //2016:

        public class Item
        {
            public int value; 
            public int row;   
            public int col;

            public Item(int value, int row, int col)
            {
                this.value = value;
                this.row = row;
                this.col = col;
            }
        }

        public class Sparse
        {
            public Item[] itemAr; 
            public int rows;      
            public int cols;

            //public SparseMatrix(int[,] sMatrix)
            //{
            //    int nonZeroCount = CountNoZero(sMatrix);
            //    int index = 0,val = 0, currentRow = 0, currentCol;

            //    for (int i = 0; i < sMatrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < sMatrix.GetLength(1); j++)
            //        {
            //            if (sMatrix[i,j] != 0)
            //            {
            //                val = sMatrix[i,j];
            //                this.itemAr[index] = new Item(val,i,j);
            //                index++;
            //            }
            //        }
            //    }
            //}
        }

        // 2017:

        public static int Place(int[,] a, int x)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {                   
                    if (a[i,j] == x)
                    {
                        return i * a.GetLength(1) + j;
                    }
                }
            }
            return -1;
        }

        public static void PrintAndCount(int[,] a, int first, int second)
        {

            for (int i = second; i >= first; i--)
            {
                int currentRow = i / a.GetLength(1);
                int currentCol = i % a.GetLength(1);

                Console.Write(a[currentRow, currentCol]);
            }
        }

        // Game Of Life:

        // לא הבנתי איך לעשות את זה :(
        
    }
}
