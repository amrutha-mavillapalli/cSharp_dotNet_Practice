using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class FibonacciAndSwapping
    {
        public static void Fibonacci()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i= 0;i<= n;i++)
                {
                Console.WriteLine(Fibo(i));
            }
           
           

        }
        public static int Fibo(int n)
        {
            return n <= 1 ? n : Fibo(n - 1) + Fibo(n - 2);
        }

        public static void Swap()
        {
            // swap two numbers without using a third variable
            Console.WriteLine("Enter two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a},{b}");

            // swap two numbers without using a third variable
            Console.WriteLine("Enter two numbers:");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = c;
            c = d;
            d = temp;
            Console.WriteLine($"{c},{d}");

        }
    }
}
