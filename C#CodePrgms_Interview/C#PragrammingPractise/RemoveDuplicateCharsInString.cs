using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class RemoveDuplicateChar
    {
        public static void removeDuplicate()
        {
            //input: csharpcorner, output: csharpone
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();

            string result = string.Empty;

            for(int i=0; i<originalString.Length;i++)
            {
                if (!result.Contains(originalString[i]))
                {
                    result += originalString[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
