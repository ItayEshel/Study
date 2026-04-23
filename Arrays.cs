using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;

namespace Arrays
{
    public class Arrays
    {
        static void Targil1()
        {
            int[] grade = new int[10];
            double sum = 0, avg, abs;
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine("enter your grade");
                grade[i] = int.Parse(Console.ReadLine());
                sum += grade[i];
            }

            avg = sum / grade.Length;
            for (int i = 0; i < grade.Length; i++)
            {
                abs = avg - grade[i];
                Console.WriteLine("grade " + (i + 1) + "  from avg " + abs);
            }
        }

        static void Targil2()
        {
            int[] square = new int[10];

            for (int i = 0; i < square.Length; i++)
            {
                square[i] = i * i;
            }

            for (int i = 0; i < square.Length; i++)
            {
                Console.WriteLine("square " + (i + 1) + " = " + square[i]);
            }
        }

        static void Targil3()
        {

            int[] t = new int[20];

            /*
            for (int i = 0; i < t.Length; i++)
            {
              if (t[i] > i)
               Console.WriteLine(i);
            }
            // מטרת הפור היא: להציג את כל המיקומים במערך שבהם הערך המאוחסן גדול מהאינדקס שלו
            */

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == 2 * i)
                    Console.WriteLine(i);

            }

        }

        static void Targil4()
        {
            int length;
            Console.WriteLine("enter length");
            length = int.Parse(Console.ReadLine());
            int[] num = new int[length];
            for (int i = 0; i < (num.Length / 2); i++)
            {
                num[i] = 0;
                Console.WriteLine(0);
            }

            for (int i = length / 2; i < num.Length; i++)
            {
                num[i] = 1;
                Console.WriteLine(1);
            }
        }

        static void Targil5()
        {
            /*
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 5 == 0)
                    Console.WriteLine(arr[i]);
            /*
            // מטרת הלולאה היא: לבדוק אם האינדקס מתחלק ב5 ללא שארית, ואם כן להדפיס אותו
            /*
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
                if (i % 5 == 0)
                    Console.WriteLine(arr[i]);
            */
            // מטרת הלולאה היא: להדפיס את המיקומים בהם המיקום מתחלק ב5 ללא שארית.

            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i += 5)
                Console.WriteLine(arr[i]);
        }

        static void Targil6()
        {
            // מטרת קטע התוכנית היא לבדוק אם המספר שווה למספר אחד אחרי במערך, ואם המספר שווה למספר אחד לפני במערך.

            // מטרת קטע התוכנית היא:לבדוק אם תשעת המספרים הבאים שווים למיקום במערך

            //----------------------------------- שאלה ג-------------------------------------------

            int[] arr = new int[20];
            int position;
            int counter = 0;

            /*
            for (int i = 1; i < 21; i++)
            {
                if (arr[position] < arr[position +i])
                    Console.WriteLine(position + i);
            }
            */

            /*
            for (int i = 1; i < 21; i++)
            {
                if (arr[position] < (arr[position + i]+1))
                    Console.WriteLine(position + i);
            }
            */
        }

        static void Targil7()
        {
            char[] arr = new char[5];
            int count = 0;
            char x = ' ', y = ' ';
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter tav");
                arr[i] = char.Parse(Console.ReadLine());
                x = arr[i];
                Console.WriteLine("enter tav");
                arr[i] = char.Parse(Console.ReadLine());
                y = arr[i];

            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == x && arr[i + 1] == y)
                {
                    count++;

                }
            }
            Console.WriteLine(count);
        }

        static void Targil19()
        {
            int[] arr = new int[25]; 
            int position, cube, newposition;

            Console.WriteLine("whats your starting position(10 - 15)");
            position = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("whats the board?(0-5)");
                arr[i] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("how much did you roll?");
            cube = int.Parse(Console.ReadLine());


            if (arr[position + cube] <= cube)
            {
                position = position - cube;
                Console.WriteLine(position);
            }
            else
            {
                position = position + cube;
                Console.WriteLine(position);
            }
        }

        static void Targil22()
        {
            // א) ערכי איברי המערך בסוף הקטע יהיו: שכל הערכים יהיו שווים לערך הראשון במערך

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int x = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
                arr[0] = x;
                Console.WriteLine(arr[i]);
            }

        }

        static void Targil23()
        {
            Console.WriteLine("how many members");
            int members = int.Parse(Console.ReadLine());
            string[] arr = new string[members];
            string name = " ";
            string x = arr[0];


            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = x;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Targil31()
        {
            Console.WriteLine("how many students");
            int students = int.Parse(Console.ReadLine());
            int[] grade1 = new int[students];
            int[] grade2 = new int[students];
            int[] finalgrade = new int[students];
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("whats grade1?");
                grade1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("whats grade2?");
                grade2[i] = int.Parse(Console.ReadLine());
                int max = Math.Max(grade1[i], grade2[i]);
                finalgrade[i] = max;
            }

            for (int i = 0; i < finalgrade.Length; i++)
            {
                Console.WriteLine("the final grade for student " + (i+1) + "is: ");
                Console.WriteLine(finalgrade[i]);
            }
        }

        public static (int[],int[]) Baaya4(int[] num)
        {
            int countP = 0, countN = 0, p = 0, n = 0 ;
            int[] pos, neg;
            for (int i = 0; i < num.Length; i++)
            {
              if (num[i] > 0)
                {
                    countP++;
                }
              else if (num[i] < 0)
                {
                    countN++;
                }
            }

            pos = new int[countP];
            neg = new int[countN];


            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    pos[p] = num[i];
                    p++;
                }
                else if (num[i] < 0)
                {
                    neg[n] = num[i];
                    n++;
                }
            }

            return (pos, neg);
        }
    }
  }
    




