using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class ClassPractice
    {
        public static void UnitTests()
        {
            CssGrades student1;
            student1 = new CssGrades("Josh", 82, 98, 87,17, 100);
            Console.WriteLine(student1);
            //student1.bagrut271 = (71);
            Console.WriteLine(student1.GetBagrut271());
            Console.WriteLine(student1);
        }

    }
}
