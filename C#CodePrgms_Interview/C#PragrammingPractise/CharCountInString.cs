using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class CharCountInString
    {
        public static void CharCount()
        {

            //input: hello world;
            //output:     h – 1
            //e – 1
            //l – 3
            //o – 2
            //w – 1
            //r – 1
            //d – 1

            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();

            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in originalString)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }



        }
    }
}
