using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace C_PragrammingPractise
{
    public class StringReverseOrder
    {
        public static void ReverseWordOrder()
        {
            //input: Welcome to Csharp program,
            //output: program Csharp to Welcome

            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();

            // method 1:using string array 
            string[] words = str.Split(' ');
            Array.Reverse(words);
            Console.WriteLine("Reverse String is:");
            for (int i = 0; i <= words.Length - 1; i++)
            {  
                Console.Write(words[i] + "" + ' ');
            }

            // method 2:
            // end represents the end index of the current word.
            int end = str.Length - 1;
            StringBuilder sb = new StringBuilder();

            //We scan the string backwards.
            // start moves from last character to index 0.
            for (int start = end; start >= 0; start--)
            {
                //When a space is found → a word ends. A full word lies between start + 1 and end.
                if (str[start] == ' ')
                {
                    //This copies the characters of the word into the output.
                    for (int i = start + 1; i <= end; i++)
                        sb.Append(str[i]);

                    sb.Append(' ');
                    end = start - 1; //So end now jumps to the last character of the previous word.
                }
            }

            // At the end of the loop, the first word is not handled inside the loop because it doesn’t have a space before it.
            //Append the first word
            for (int i = 0; i <= end; i++)
                sb.Append(str[i]);

            Console.WriteLine(sb.ToString());
        


    }
}
}
