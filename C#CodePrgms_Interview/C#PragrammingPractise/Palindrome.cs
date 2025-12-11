using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class Palindrome
    {
        public static void PalindromeChecker()
        {
            //input: madam, output: Palindrome  
            // input: step on no pets, output: Palindrome
            Console.WriteLine($"Enter a string to check whether it's a palindrom or not:");
            string mainStr = Console.ReadLine();

            string str = mainStr.ToLower(); // either convert string to lower or upper case.

            bool flag = false;  // making string as not palindrom at first.
            int strLength = str.Length;

            for (int i = 0, j = strLength - 1; i < strLength / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine($"{mainStr} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{mainStr} is not a Palindrome");
            }
        }
    }
}



