namespace MyPractise
{
    public class ClsOptional_parameter_ParameterArrays
    {
        // Method with optional parameters
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] numbers)
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

        public static void OptionalParameterParameterArraysExample()
        {
            // Calling method with parameter array
            AddNumbers(1, 2, 3); // Passing individual numbers
            AddNumbers(10, 20, 30, 40, 50); // Passing multiple individual numbers
            AddNumbers(10,20,new object[] { 1, 2, 3, 4, 5 }); // Passing an array
            AddNumbers(5, 15); // No additional numbers
        }
    }
}