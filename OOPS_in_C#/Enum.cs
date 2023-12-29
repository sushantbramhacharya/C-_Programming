using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_in_C_
{
    internal class Enum
    {
        static void GetSum(out double answer,double x = 1, double y = 1)
        {
            answer= x+y;
        }
        internal Enum() {
            double x = 5;
            double y = 4;

            double answer;
            //Manipulating Values outside the method.Using out keyword
            //Passing Reference of the var answer
            //Out doesnt need to be initilized
            GetSum(out answer,x, y);
            Console.WriteLine("The answer of the calculation is "+answer);
        }
    }
}
