using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Date
    {
        public static void UnitTests()
        {
            Date date;
            date = new Date(7, 9, 2010);
            Console.WriteLine("date is " + date);
            Console.WriteLine("---------------------------------");
            date.SetDay(21);
            date.SetMonth(11);
            date.SetYear(2009);
            Console.WriteLine("new day: " + date.GetDay());
            Console.WriteLine("new month: " + date.GetMonth());
            Console.WriteLine("new year: " + date.GetYear());
            Console.WriteLine("new date: " + date);
            Console.WriteLine("-----------------------------------------");
            Date date2 = new Date();
            Date date3 = new Date(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date2);
            Console.WriteLine(date2.CompareTo(date));


        }
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)
        {

        }
        public Date(Date d) : this(d.GetDay(), d.GetMonth(), d.GetYear()) { }

        public int GetDay()
        {
            return this.day;
        }
        public void SetDay(int dayToSet)
        {
            this.day = dayToSet;
        }
        public int GetMonth()
        {
            return this.month;
        }
        public void SetMonth(int monthToSet)
        {
            this.month = monthToSet;
        }
        public int GetYear()
        {
            return this.year;
        }
        public void SetYear(int yearToSet)
        {
            this.year = yearToSet;
        }

        public int CompareTo(Date other)
        {
            int num = 0;
            if (this.day == other.day && this.month == other.month && this.year == other.year)
            {
                num = 0;
            }
            else if (this.year > other.year)
                num = 1;
            else if (this.year < other.year)
                num = -1;
            else if (this.year == other.year)
            {
                if (this.month > other.month)
                {
                    num = 1;
                }
                else if (this.month < other.month)
                {
                    num = -1;
                }
                else if (this.month == other.month)
                {
                    if (this.day > other.day)
                    {
                        num = 1;
                    }
                    else if (this.day < other.day)
                    {
                        num = -1;
                    }
                }
            }

            return num;
        }

        public override string ToString()
        {
            return $"{this.day}/{this.month}/{this.year}";
        }
    }
}
