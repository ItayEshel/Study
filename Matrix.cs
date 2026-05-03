using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Matrix
    {
        public static void UnitTests()
        {
            int[,] grades = { { 80, 90, 100, }, { 50, 60, 70 } };
            Console.WriteLine(Matrix.avrg(grades)) ;

        }   

       
        public static double avrg(int[,] grades)
        {
            int sum = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    sum += grades[row, col];
                }
            }
            return (double)sum / grades.Length;
        }

        public static double AvrgStudent(int[,] grades, int stu)
        {
            int sum = 0;
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    sum += grades[stu, col];
                }
            
            return (double)sum / grades.GetLength(1);
        }

        public static double avrgExam(int[,] grades, int stu)
        {
            int sum = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                sum += grades[row,stu];
            }

            return (double)sum / grades.GetLength(0);
        }

        public static double Max(int[,] grades)
        {
            int max = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                    if (grades[row, col] > max)
                        max = grades[row, col];
            }
            return max;
        }







        }
    }

