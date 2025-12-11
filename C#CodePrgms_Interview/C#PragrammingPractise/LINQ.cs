using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class LINQ
    {
        public static void LinqExamples()
        {
            // printing even numbers using LINQ
            var num = new List<int> { 1, 2, 3, 4, 5 };
            var evenNum = num.Where(n => n % 2 == 0);
            Console.WriteLine(String.Join(",", evenNum));


            //Sorting using LINQ
            var sortNums = num.OrderBy(n=>n).ToList();
            Console.WriteLine(String.Join(",", sortNums));

        }
    }
}
