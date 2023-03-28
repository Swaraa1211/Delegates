using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void mathOperations(int a, int b);
    internal class Delegate1
    {
        static void Main(string[] args)
        {
            mathOperations d1 = add;
            mathOperations d2 = sub;
            mathOperations d3 = mul;
            mathOperations d4 = div;
            mathOperations d5 = d1 + d2 + d3;

            //Delegate[] arr = d5.GetInvocationList();
            /*foreach(var item in arr)
            {
                Console.WriteLine(item);
            }*/
            d5.Invoke(5, 4);

            //d5 -= d1;
            d5 += d4;
            d5.Invoke(3, 2);
        }

        static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
