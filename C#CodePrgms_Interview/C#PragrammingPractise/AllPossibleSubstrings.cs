using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class AllPossibleSubstrings
    {
        public static void Substrings()
        {
            //input: abcd , output : a ab abc abcd b bc bcd c cd d

            Console.Write("Enter a String : ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }

        }
    }
}
