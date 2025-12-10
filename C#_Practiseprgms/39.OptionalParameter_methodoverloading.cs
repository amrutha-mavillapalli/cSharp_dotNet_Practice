namespace MyPractise
{
    public class ClsOptional_parameter_MethodOveroading
    {
        public static void AddNumbers(int firstNumber, int secondNumber, int[] numbers)
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
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }
        public static void OptionalParameterMethodOverloadingExample()
        {
            // Calling method with array
            AddNumbers(1, 2, new int[] { 3, 4, 5 }); // Passing an array
            AddNumbers(10, 20); // No additional numbers
        }
    }
}