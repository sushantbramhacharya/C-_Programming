using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_in_C_
{
    internal class Enum
    {
        internal Enum()
        {
            double x = 5;
            double y = 4;

            double answer;
            //Manipulating Values outside the method.Using out keyword
            //Passing Reference of the var answer
            //Out doesnt need to be initilized
            GetSum(out answer, x, y);
            Console.WriteLine("The answer of the calculation is " + answer);

            //Pass by refernce using ref keyword
            int a = 10, b = 20;
            Console.WriteLine("Before Swap a is {0} b is {1}", a, b);
            SwapInt(ref a, ref b);
            Console.WriteLine("After Swap a is {0} b is {1}", a, b);

            //Params keyword
            Console.WriteLine("Get Sum more {0} + {1} + {2} = {3}", a, b, x, GetSumMore(a, b, x));

            PrintInfo(zipCode: 15167, name: "Sus");
        }
        static void GetSum(out double answer,double x = 1, double y = 1)
        {
            answer= x+y;
        }
        static void SwapInt(ref int num1,ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
        static double GetSumMore(params double[] nums) 
        { 
            double answer=0;
            foreach(double x in nums)
            {
                answer += x;
            }
            return answer;
        }

        static void PrintInfo(string name,int zipCode)
        {
            Console.WriteLine(name + " Lives in zip code " + zipCode);
        }
    }
}
