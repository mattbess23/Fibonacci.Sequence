using System;

namespace Fibonacci_Sequence
{

    class Program
    {
        public static int FibonacciSequence(int n)
        {
            int a = 0;
            int b = 2;
            // n variable calculates the fibonacci in iteration
            for (int i = 0; i < n; i++){
                int calc = a;
                a = b;
                b = calc + b;}
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 5000000; i++){
                if (i == 5000000)
                    break;

                Console.WriteLine(FibonacciSequence(i));
                Console.ReadLine();}
        }
    }
}


