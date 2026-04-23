using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Arrays
{
    public class ArraysHw
    {
        static void Targil31()
        {
            Console.WriteLine("how many students");
            int students = int.Parse(Console.ReadLine());
            int[] grade1 = new int[students];
            int[] grade2 = new int[students];
            int[] finalgrade = new int[students];
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("student " + (i + 1) + ":");
                Console.WriteLine("whats grade1?");
                grade1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("whats grade2?");
                grade2[i] = int.Parse(Console.ReadLine());
                int max = Math.Max(grade1[i], grade2[i]);
                finalgrade[i] = max;
                Console.WriteLine("-----------------------------------------");
            }

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("student " + (i + 1) + ":");
                Console.WriteLine("first grade: " + grade1[i]);
                Console.WriteLine("second grade: " + grade2[i]);
                Console.WriteLine("final grade: " + finalgrade[i]);
                Console.WriteLine("-----------------------------------------");
            }

        }

        static void Targil33()
        {
            int CountEven = 0, CountOdd = 0, e = 0, o = 0;
            Console.WriteLine("enter length");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int[] odd, even;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter num " + (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    CountEven++;
                }
                else if (arr[i] % 2 != 0)
                {
                    CountOdd++;
                }
            }

            even = new int[CountEven];
            odd = new int[CountOdd];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else if (arr[i] % 2 != 0)
                {
                    odd[o] = arr[i];
                    o++;
                }
            }

            Console.WriteLine("even numbers: " + string.Join("|", even));
            Console.WriteLine("odd numbers: " + string.Join("|", odd));
        }

        static void Targil34()
        {
            int length1, length2, pos = 0;
            bool exists;

            Console.WriteLine("enter length1");
            length1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length1];
            Console.WriteLine("enter length2");
            length2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[length2];

            int max = Math.Max(length1, length2);
            int[] arr3 = new int[max];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("enter num " + (i + 1));
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("enyer num " + (i + 1));
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                exists = false;

                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        exists = true;
                    }
                }

                if (exists == true)
                {
                    arr3[pos] = arr1[i];
                    pos++;
                }
            }

            Console.WriteLine("first array: " + string.Join("|", arr1));
            Console.WriteLine("second array: " + string.Join("|", arr2));
            Console.WriteLine("third array: " + string.Join("|", arr3));
        }

        static void Targil36()
        {
            int vote = 0;
            Console.WriteLine("Enter number of students:");
            int students = int.Parse(Console.ReadLine());

            int[] votes = new int[students];
            string[] names = { "Ruti", "Eli", "Aviv", "Ofir" };
            int[] counts = new int[4];

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("sudent " + (i + 1) + " enter your vote" + ":");
                Console.WriteLine("1 - Ruti, 2 - Eli, 3 - Aviv, 4 - Ofir");
                vote = int.Parse(Console.ReadLine());
                votes[i] = vote;
            }

            for (int i = 0; i < votes.Length; i++)
            {
                vote = votes[i];
                counts[vote - 1]++;
            }

            int max = counts[0];
            int winner = 0;

            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] > max)
                {
                    max = counts[i];
                    winner = i;
                }
            }

            Console.WriteLine("Winner: " + names[winner]);
        }

        static void Targil37()
        {
            Console.WriteLine("how mant times did you roll the dice?");
            int rolls = int.Parse(Console.ReadLine());

            int[] arr = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < rolls; i++)
            {
                int roll = rnd.Next(1, 7);
                arr[roll - 1]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + " appeared " + arr[i] + " times.");
            }
        }

        static void Targil38()
        {
            Random rnd = new Random();
            int[] arr = new int[6];
            int winner = 0;
            bool W = false;

            while (W == false)
            {
                int roll = rnd.Next(1, 7);
                arr[roll - 1]++;

                if (arr[roll - 1] == 2)
                {
                    winner = roll;
                    W = true;
                }
            }

            Console.WriteLine("The winning number is: " + winner);
        }


        static void Targil40()
        {
            Random rnd = new Random();

            Console.WriteLine("Enter number of players:");
            int players = int.Parse(Console.ReadLine());

            string[] colors = new string[players];
            int[] Counts = new int[players];

            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("Enter color for player " + (i + 1) + ":");
                colors[i] = Console.ReadLine();
            }

            Console.WriteLine("Press <Enter> to draw a color, or Q to quit.");

            bool gameFinished = false;
            int winner = 0;

            while (gameFinished == false)
            {
                string keyPressed = Console.ReadLine();

                if (keyPressed == "Q" || keyPressed == "q")
                {
                    gameFinished = true;
                }
                else
                {
                    int drawnColor = rnd.Next(0, players);
                    string chosenColor = colors[drawnColor];
                    Counts[drawnColor]++;
                    Console.WriteLine("Drawn color: " + chosenColor);
                }
            }

            int maxCount = 0;
            for (int i = 0; i < Counts.Length; i++)
            {
                if (Counts[i] > maxCount)
                {
                    maxCount = Counts[i];
                    winner = i;
                }
            }

            Console.WriteLine("the winning color is: " + colors[winner]);
        }


        static void Targil41()
        {
            int players = 4;
            int[] points = new int[players];

            Console.WriteLine("Enter number of rounds:");
            int numRounds = int.Parse(Console.ReadLine());

            for (int round = 1; round <= numRounds; round++)
            {
                Console.WriteLine($"Round {round}:");

                Console.Write("Enter player number for 1st place: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Enter player number for 2nd place: ");
                int second = int.Parse(Console.ReadLine());
                Console.Write("Enter player number for 3rd place: ");
                int third = int.Parse(Console.ReadLine());

                points[first - 1] += 7;
                points[second - 1] += 3;
                points[third - 1] += 0;

                for (int i = 0; i < players; i++)
                {
                    if (i != first - 1 && i != second - 1 && i != third - 1)
                    {
                        points[i] -= 4;
                    }
                }
            }

            int maxPoints = 0;
            int winner = 0;
            for (int i = 0; i < players; i++)
            {
                if (points[i] > maxPoints)
                {
                    maxPoints = points[i];
                    winner = i;
                }
            }

            Console.WriteLine("The winning player is: Player number " + (winner + 1));
        }


        static void Targil42()
        {
            Console.WriteLine("how many videos?");
            int vids = int.Parse(Console.ReadLine());
            int[] codes = new int[6];
            int[] counts = new int[vids];
            Console.WriteLine("enter code");
           int code = int.Parse(Console.ReadLine());
            int max = codes[0], maxclass=0 ;


            while (code != 0)
            {
                codes[code / 1000]++;
                Console.WriteLine("enter code");
                code = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= codes.Length; i++)
            {
              if (codes[i] > max)
                {
                    max = codes[i];
                    maxclass = i;
                }
            }

            Console.WriteLine("max class is: " + maxclass);
        }
    }
}

  
     
    

