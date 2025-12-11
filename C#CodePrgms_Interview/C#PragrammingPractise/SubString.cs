using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class SubString
    {
        public static void SubStringExample()
        {
            //string mainString = "Hi, Welcome C# Programming!";
            Console.WriteLine($"Enter a string");
            string mainString = Console.ReadLine();

            // Selects the substring function with Start Index.
            string subString = mainString.Substring(14);

            //Seelct the substring with both start index with length.
            string subString1 = mainString.Substring(12, 15);

            Console.WriteLine($"substring is {subString}.");
            Console.WriteLine($"substring1 is {subString1}.");

            try
            {
                string subString2 = mainString.Substring(30);
                Console.WriteLine($"substring2 is {subString2}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");

            }

        }
    }
}
