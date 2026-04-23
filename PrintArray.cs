using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class PrintArray
    {
        public static string PrintArrays<T>(T[] array)
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
    }
}

