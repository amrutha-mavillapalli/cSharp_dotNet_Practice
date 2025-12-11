using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    internal class StringReverse
    {
        public static void StringReversor()
        {
            //input: hello, output: olleh

            Console.WriteLine($"Enter a string");
            string mainString = Console.ReadLine();

            string revString = "";

            for(int i= mainString.Length - 1; i>=0 ;i--)
            {
                revString += mainString[i]; 
            }
                
            Console.WriteLine($"{revString} is reversed string");
            
            // method2:
            // or we can use char array in a method
            char[] charArray = mainString.ToCharArray();
            Array.Reverse(charArray);
            string str1= new string(charArray);
            Console.WriteLine(str1);
           
          

        }
    }
}
