using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C_PragrammingPractise
{
    internal class ReverseEachWordInString
    {
        public static void WordReverseInString()
        {
            //Welcome to Csharp corner, output: emocleW ot prahsC renroc
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();

            // using LINQ
            string reverseWordString = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine($"Reverse Word String : {reverseWordString}");
        }

    }
}
