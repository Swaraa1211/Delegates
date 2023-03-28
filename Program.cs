using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    delegate void delegateForSum(int a, int b); //declaring delegate(signature)
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            //int x = 10;
            //int y = 20;
            delegateForSum d1 = obj.Sum;
            d1 += obj.Diff; //multicast delegate
            d1(20, 50);

            d1.Invoke(30, 60);

            d1 -= obj.Diff;

            d1(80, 70);
            //Sum(x, y);
        }
        private void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }


}