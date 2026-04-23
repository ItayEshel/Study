using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Study
{
    public class Passport
    {
        private string name;
        private int number;
        private Date expiryDate;

        public Passport(string name, int number, Date expiryDate)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }

        public Passport(Passport passport) : this(passport.name, passport.number, passport.expiryDate) { }

        public bool IsValid(Date dateChecked)
        {
           
          if(this.expiryDate.CompareTo(dateChecked) >= 0)
            {
                return true;
            }
          else
            {
                return false;
            }

        }

        public void SetExpiryDate(Date expiryDate)
        {
            this.expiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"Name: {name} " +
                   $"Pass.num: {number}" +
                   $"Exp Date: {expiryDate}";

        }

        public static void UnitTests()
        {
            Date d = new Date(7, 9, 2010);
            Passport p = new Passport("Itay", 1122, d);
            Console.WriteLine("the passport info is " + p);
            Date d2 = new Date(7, 9, 2010);
            Console.WriteLine("new date is: " + d2);
            bool valid = p.IsValid(d2);
            Console.WriteLine("is the passport valid: " + valid);
            d.SetDay(21);
            d.SetMonth(11);
            d.SetYear(2009);
            Console.WriteLine("new day: " + d.GetDay());
            Console.WriteLine("new month: " + d.GetMonth());
            Console.WriteLine("new year: " + d.GetYear());
            Console.WriteLine("new date: " + d);
            Console.WriteLine("-----------------------------------------");


        }
    }
}
