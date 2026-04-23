using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Traveler
    {
        private Passport passport;
        private bool hasPaid;

        public Traveler(Passport passport, bool hasPaid)
        {
            this.passport = passport;
            this.hasPaid = hasPaid;
        }

        public void Pay()
        {
            this.hasPaid = true;
        }

        public bool HasPaid()
        {
            return this.hasPaid;
        }

         public bool CheckTravel(Date travelDate)
        {
            bool valid = this.passport.IsValid(travelDate);
            if(valid && this.HasPaid())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Passport info: {passport}" +
                 $"Did he pay: {hasPaid}";
        }

        public static void UnitTests()
        {
            Date exp = new Date(7, 9, 2010);
            Date d = new Date(7, 9, 2010);
            Passport p = new Passport("Ido", 12321, exp);
            Traveler t = new Traveler(p, true);
            Console.WriteLine("the traveler info is " + t);
            bool pay = t.HasPaid();
            Console.WriteLine("did the traveler pay: " + pay);
            bool goodD = p.IsValid(d);
            Console.WriteLine("is the date good: " + goodD);
            bool allowed = t.CheckTravel(d);
            Console.WriteLine("is the traveler allowed: " + allowed);

        }

    }


}
