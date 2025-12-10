using System;
using System.Runtime.InteropServices;
namespace MyPractise
{
    public class ClsOptional_parameter_using_optionalAttribute
    {
         public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] numbers)
        {
            int sum = firstNumber + secondNumber;
            if (numbers != null)
            {
                foreach (int i in numbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
        public static void OptionalParameterOptionalAttributeExample()
        {
            // Calling method with all parameters
            AddNumbers(10, 20, new int[] { 30, 40, 50 });

            // Calling method with only the required parameter
            AddNumbers(10,20);
        }
    }
}