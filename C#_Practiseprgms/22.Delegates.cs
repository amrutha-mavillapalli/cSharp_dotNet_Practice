namespace MyPractise
{
    public class ClsDelegates
    {
        // Step 1: Define a delegate type
        public delegate int MathOperation(int a, int b);

        // Step 2: Create methods that match the delegate signature
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Step 3: Method to demonstrate delegate usage
        public static void DelegateExample()
        {
            // Instantiate the delegate with the Add method
            // passing method as a parameter
            MathOperation operation = new MathOperation(Add);
            int result = operation(10, 5);
            Console.WriteLine("Addition Result: " + result);

            // Change the delegate to point to the Subtract method
            operation = new MathOperation(Subtract);
            result = operation(10, 5);
            Console.WriteLine("Subtraction Result: " + result);
        }
    }
}