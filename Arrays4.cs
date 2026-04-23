using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Arrays
{
    internal class Arrays4
    {
        static void Targil1()
        {
            int bestplayer = 0, max = 0, Totalpoints = 0, points = 0, sum = 0, besttype = 0;
            string loser = "";
            int[] Playersscores = new int[5];
            int[] typepoints = new int[3];
            Console.WriteLine("enter player number");
            int player = int.Parse(Console.ReadLine());

            while (player != 0)
            {
                Console.WriteLine("how much did u score?");
                points = int.Parse(Console.ReadLine());
                Totalpoints += points;
                Playersscores[player - 1] += points;
                typepoints[points - 1]++;
                Console.WriteLine("enter player number");
                player = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i < Playersscores.Length; i++)
            {
                if (max < Playersscores[i])
                {
                    max = Playersscores[i];
                    bestplayer = i + 1;
                }
            }

            for (int i = 1; i < Playersscores.Length; i++)
            {
                if (Playersscores[i] == 0)
                {
                    loser += $"{(i + 1)}";
                }
            }

            for (int i = 1; i < typepoints.Length; i++)
            {
                if (typepoints[i] > max)
                    max = typepoints[i];
                besttype = i;
            }

            Console.WriteLine("player who scored the most points is: " + bestplayer);
            Console.WriteLine("player who scored 0: " + loser);
            Console.WriteLine("the team scored: " + Totalpoints);
            Console.WriteLine("the most typed score is :" + besttype);
        }

        static void Targil2()
        {
           // הפלטים הם: 5,3
           // int[] arr = {2,4,6,8,10,12,14,1,3,5};
           // מטרת קטע התוכנית  היא למספר כמה ערכים זוגיים וכמה אי זוגיים במערך
        }

        static void Targil3()
        {
            // הביטוי החשבוני הוא a-z

            int[] Counts = new int[26];
            char tav;
            Console.WriteLine("enter tav");
            tav = char.Parse(Console.ReadLine());

            while (tav != '*')
            {
                if (tav >= 'a' && tav <= 'z')
                {
                    Counts[tav - 'a']++;
                }
                Console.WriteLine("enter tav");
                tav = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Counts.Length; i++)
            {
                Console.WriteLine($"{Counts[i]}");
            }

        }

        static void Targil4()
        {
            int[] ageGroup = new int[4];

        }
    }
}
