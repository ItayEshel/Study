using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class MoreArrays
    {
        public static void UnitTest()
        {
            /*  Targil 2
            string[] names = { "Itay", "Noam", "Gali", "Daniel", "Omer" };
            int[] grades = { 85, 70, 90, 60, 95 };
            MoreArrays.Targil2(names, grades);
            */

            /*  Targil 3
            int[] result = MoreArrays.Targil3(5);
            Console.WriteLine("first place: " + result[0]);
            Console.WriteLine("second place: " + result[1]);
            */

            /*  Targil 4
            MoreArrays.Targil4(2);
            */

            /*  Targil 6
            int[] project = { 100, 80, 70 };
            int[] magen = { 90, 90, 60 };
            int[] bagrut = { 95, 70, 80 };
           
            Console.WriteLine(PrintArray(MoreArrays.Targil6b(project, magen, bagrut)));
            */

            /*  Targil 7
            int[] arr1 = { 5,5,5,};
            int[] arr2 = {5};
            int num = 5;
            Console.WriteLine(PrintArray(MoreArrays.Targil7(arr1, arr2, num)));
            */

            //Targil 8
            //int[] arr = { 2, 5, 7 };
            //int num = MoreArrays.Targil8(arr);
            //Console.WriteLine(num);


            /* Targil 9
            int age = 15;
            Console.WriteLine(PrintArray(MoreArrays.Targil9a(age)));
            */

            /* Targil 9b
            int day, Makpetza = 0, Hottub = 0, Sauna = 0, age;
            Console.WriteLine("what is your age?");
            age = int.Parse(Console.ReadLine());
            while (age >= 12)
            {
                int[] arr = MoreArrays.Targil9a(age);
                if (arr[0] == 1)
                    Makpetza++;
                if (arr[1] == 1)
                    Hottub++;
                if (arr[2] == 1)
                    Sauna++;
                Console.WriteLine("what is your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"people who allowed to use the Makpetza: {Makpetza}");
            Console.WriteLine($"people who allowed to use the Hottub: {Hottub}");
            Console.WriteLine($"people who allowed to use the Sauna: {Sauna}");
            */

            /* Targil10a
            //int startlevel = 6, startunit = 2, currentlevel = 9, currentunit = 1;
            //int finishedunits = MoreArrays.Targil10(startlevel, startunit, currentlevel, currentunit);
            //Console.WriteLine(finishedunits);
            */

            /* Targil 10b
            int[] arr = { 17, 18, 19, 3 };
            int max = MoreArrays.Targil10b(arr);
            Console.WriteLine(max);
            */

            int[] students = new int[4];
            int finalGrade = 0;
            int startLevel = 0, startUnit = 0, currentlevel = 0, currentunit = 0;
            int max = 0;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("whats the start level for student num: " + i);
                startLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("whats the current level for student num: " + i);
                currentlevel = int.Parse(Console.ReadLine());
                Console.WriteLine("whats the start level for student num: " + i);
                startUnit = int.Parse(Console.ReadLine());
                Console.WriteLine("whats the start level for student num: " + i);
                currentunit = int.Parse(Console.ReadLine());

                finalGrade = MoreArrays.Targil10(startLevel, startUnit, currentlevel, currentunit);
                max = MoreArrays.Targil10b(students);
                if (max > finalGrade)
                {
                    max = finalGrade;
                }
            }

            Console.WriteLine("the most units that a person finished was: " + max);
        }


        public static string PrintArray<T>(T[] array)
        {
            string sum = "";
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (i < array.Length - 1)
                    sum += ",";
            }
            return sum;
        }
        public static int Targil1(int n)
        {
            int invalid = 0;
            int[] ressistence = new int[n];
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("what is the ressitence for ressistor num " + (i + 1));
                ressistence[i] = int.Parse(Console.ReadLine());
                total += ressistence[i];
            }

            int avg = total / n;

            for (int i = 0; i < n; i++)
            {
                if (ressistence[i] < (avg * 0.9) || ressistence[i] > (avg * 1.1))
                {
                    invalid++;
                }
            }
            return invalid;
        }

        public static void Targil2(string[] name, int[] grade)
        {
            int total = 0, avg;
            for (int i = 0; i < name.Length; i++)
            {
                total += grade[i];
            }
            avg = total / name.Length;

            for (int i = 0; i < name.Length; i++)
            {
                if (grade[i] > avg)
                {
                    Console.WriteLine(name[i] + " got accepted to CS");
                }

            }
        }

        public static int[] Targil3(int N)
        {
            int[] count = new int[N];
            int[] winners = new int[2];
            int max = 0, secondmax = 0;
            int maxnum = 0, secondmaxnum = 0; ;
            Console.WriteLine("who did u vote for?");
            int vote = int.Parse(Console.ReadLine());

            while (vote != -1)
            {
                count[vote - 1]++;
                Console.WriteLine("who did u vote for?");
                vote = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < N; i++)
            {
                if (count[i] > max)
                {
                    secondmax = max;
                    secondmaxnum = maxnum;


                    max = count[i];
                    maxnum = i;
                }
                if (count[i] > secondmax && count[i] < max)
                {
                    secondmax = count[i];
                    secondmaxnum = i;
                }


            }
            winners[0] = maxnum + 1;
            winners[1] = secondmaxnum + 1;

            return winners;

        }

        public static void Targil4(int N)
        {
            int[] count = new int[N];
            int vote = 0;
            string winners = " ";
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"votes for school number: {i + 1} ");
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("enter your vote");
                    vote = int.Parse(Console.ReadLine());
                    count[i] += vote;
                }
            }

            bool flag = true;
            int max = count[0];

            for (int i = 0; i < N; i++)
            {
                if (count[i] == max && flag)
                {
                    max = count[i];
                    flag = false;
                }
            }
            Console.WriteLine("the winners are: ");
            for (int i = 0; i < N; i++)
            {
                if (count[i] == max)
                {
                    Console.WriteLine("School " + (i + 1));
                }
            }

        }

        public static void Targil5a(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = x;
        }

        public static void Targil5b(int[] arr)
        {
            int y = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = y;
        }

        public static int Targil6a(int proj, int magen, int bagrut)
        {
            int finalgrade = 0;
            finalgrade = (int)((proj * 0.3) + (magen * 0.21) + (bagrut * 0.49) + 0.5);
            return finalgrade;
        }

        public static int[] Targil6b(int[] proj, int[] magen, int[] bagrut)
        {

            int[] FinalGrade = new int[proj.Length];

            for (int i = 0; i < FinalGrade.Length; i++)
            {
                FinalGrade[i] = MoreArrays.Targil6a(proj[i], magen[i], bagrut[i]);

            }

            return FinalGrade;
        }

        public static int[] Targil7(int[] arr1, int[] arr2, int num)
        {
            int t = 0;
            int rt = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && arr1[i] % num == 0)
                    {
                        t++;
                    }
                }
            }
            int[] arr = new int[t];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && arr1[i] % num == 0)
                    {
                        arr[rt] = arr1[i];
                        rt++;
                    }
                }
            }

            return arr;
        }

        public static int Targil8(int[] arr)
        {
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                num = (num * 10) + arr[i];
            }

            return num;
        }

        public static int[] Targil9a(int age)
        {
            int[] arr = new int[3];
            int[] newarr = new int[arr.Length];

            if (age >= 12)
                newarr[0] = 1;
            else
                newarr[0] = 0;
            if (age >= 16)
                newarr[1] = 1;
            else
                newarr[1] = 0;
            if (age >= 18)
                newarr[2] = 1;
            else
                newarr[2] = 0;

            return newarr;
        }

        static void Targil9b()
        {
            int day, Makpetza = 0, Hottub = 0, Sauna = 0, age;
            Console.WriteLine("what is your age?");
            age = int.Parse(Console.ReadLine());

            while (age >= 12)
            {
                int[] arr = MoreArrays.Targil9a(age);
                if (arr[0] == 1)
                    Makpetza++;
                if (arr[1] == 1)
                    Hottub++;
                if (arr[2] == 1)
                    Sauna++;
                Console.WriteLine("what is your age?");
                age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"people who allowed to use the Makpetza: {Makpetza}");
            Console.WriteLine($"people who allowed to use the Hottub: {Hottub}");
            Console.WriteLine($"people who allowed to use the Sauna: {Sauna}");

        }

        public static int Targil10(int startlevel, int startunit, int currentlevel, int currentunit)
        {
            return (currentlevel - startlevel) * 2 + (currentunit - startunit);
        }
        public static int Targil10b(int[] arr)
        {
            int max=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static void Targil10c()
        {
            int[] students = new int[2000];
            int finalGrade = 0;
            int startLevel = 0, startUnit = 0, currentlevel = 0, currentunit = 0;
            int max=0;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("whats the start level for student num: " + (i+1));
                startLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("whats the current level for student num: " + (i + 1));
                currentlevel = int.Parse(Console.ReadLine());
                Console.WriteLine("whats the start level for student num: " + (i + 1));
                startUnit = int.Parse(Console.ReadLine());
                Console.WriteLine("whats the start level for student num: " + (i + 1));
                currentunit = int.Parse(Console.ReadLine());

                finalGrade = MoreArrays.Targil10(startLevel, startUnit, currentlevel, currentunit);
                max = MoreArrays.Targil10b(students);
                if (max > finalGrade)
                {
                    max = finalGrade;
                }
            }

            Console.WriteLine("the most units that a person finished was: " + max);
        }

        //public static int[] Targil11(int registered)
        //{

        //}

    }
}
