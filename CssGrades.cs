using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class CssGrades
    {
       private string name;
       private int magen371;
       private int bagrut371;
       private int magen271;
       private int bagrut271;
       private int proj;
       
      public CssGrades(string name, int magen371, int bagrut371, int magen271, int bagrut271, int proj)
        {
            this.name = name;
            this.magen371 = magen371;
            this.bagrut371 = bagrut371;
            this.magen271 = magen271;
            this.bagrut271 = bagrut271;
            this.proj = proj;
        }
        public void SetBagrut271(int b2)
        {
            if (b2 >= 0 && b2 <= 100)
            {
                bagrut271 = b2;
            }
        }

        public int GetBagrut271()
        {
            return bagrut271;
        }
         public int Calc371()
         {
            return (int)(magen371 * 0.3 + bagrut371 * 0.7 + 0.5);
         }
        private int calc3()
        {
            return (int)(Calc371() * 0.6 + proj * 0.4 + 0.5);
        }
        private int Calc271()
        {
            return (int)(magen271 * 0.4 + bagrut271 * 0.6 + 0.5);
        }
        private bool has5()
        {
            return bagrut271 >= 55;
        }
        private int Calc5()
        {
            return (int)(Calc371() * 0.4 + calc3() * 0.6 + 0.5);
        }
        //public string FinalString()
        //{
        //    string s = "";
        //    int f371 = Calc371();
        //    int f3 = calc3();
        //    int final;
        //    if (has5())
        //    {
        //        s = "You got 5 units in CS!\n";
        //        int f271 = Calc271();
        //        final = Calc5();
        //    }
        //    else
        //    {
        //        s = "You got 3 units in CS!\n";
        //        final = f3;
        //    }
        //    s += "Your final grade is: " + final;
        //    return s;
        //}

        public override string ToString()
        {
            string s = "";
            int f371 = Calc371();
            int f3 = calc3();
            int final;
            if (has5())
            {
                s = "You got 5 units in CS!\n";
                int f271 = Calc271();
                final = Calc5();
            }
            else
            {
                s = "You got 3 units in CS!\n";
                final = f3;
            }
            s += "Your final grade is: " + final;
            return s;
        }

        public static void UnitTests()
        {
            CssGrades student1 = new CssGrades("Josh", 80, 91, 83, 17, 85);
            Console.WriteLine(student1);
            Console.WriteLine("------------------------------------------");
            student1.SetBagrut271(-71);
            Console.WriteLine(student1);
            Console.WriteLine("------------------------------------------");
            student1.SetBagrut271(71);
            Console.WriteLine(student1);

           
        }

    }
}
