namespace MyPractise
{
    public class ClsExceptionHandlingAbuseAndPrevention
    {
        public static void ExceptionHandlingAbuse()
        {
            // Example of exception handling abuse
            // This example demonstrates catching general exceptions without specific handling
            try
            {
                Console.WriteLine("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: {0}", result);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter numeric values. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed. Thank you!");
            }
        }
        public static void ExceptionHandlingPrevention()
        {
            // Example of preventing exceptions through validation
            try
            {
                Console.WriteLine("Enter first number: ");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter second number: ");
                string input2 = Console.ReadLine();

                // Validate inputs before conversion
                if (!int.TryParse(input1, out int num1))
                {
                    Console.WriteLine("Error: Invalid input format for the first number. Please enter a numeric value.");
                    return;
                }

                if (!int.TryParse(input2, out int num2))
                {
                    Console.WriteLine("Error: Invalid input format for the second number. Please enter a numeric value.");
                    return;
                }

                // Prevent division by zero
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }

                int result = num1 / num2;
                Console.WriteLine("Result: {0}", result);
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed. Thank you!");
            }
        }
    }
}