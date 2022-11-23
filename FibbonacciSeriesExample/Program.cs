using System;

namespace FibbonacciSeriesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 0; int fib2 = 1;int fib3 = 0;
            Console.WriteLine("please enter the starting range :");
            int startingRange = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the ending range :");
            int endingRange = int.Parse(Console.ReadLine());
            Console.WriteLine(fib1 + " " + fib2 + " ");
            for(int i= startingRange;i<= endingRange;i++)
            {
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2=fib3;
                Console.WriteLine(fib3);
            }
            Console.ReadLine();

        }
    }
}
