namespace MyPractise
{
    public class ClsMethodsAndParameters
    {
        // Method with no parameters and no return value
        public static void Greet()
        {
            Console.WriteLine("\nHello! Welcome to the Methods and Parameters example.");
        }

        // Method with parameters and no return value
        public static void DisplaySum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of {0} and {1} is {2}.", a, b, sum);
        }

        // Method with parameters and a return value
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Method with optional parameters
        public static void PrintMessage(string message, int repeatCount = 1)
        {
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(message);
            }
        }

        // Method with named parameters
        public static void Introduce(string name, int age)
        {
            Console.WriteLine("My name is {0} and I am {1} years old.", name, age);
        }

        public static void MethodsAndParameters()
        {
            Greet();

            DisplaySum(5, 10);

            int product = Multiply(4, 6);
            Console.WriteLine("The product of 4 and 6 is {0}.", product);

            PrintMessage("This is a message.", 3);
            PrintMessage("This message is printed once.");

            Introduce(age: 25, name: "Alice");
        }

        //4 types of method parameters.
        //1. Value Parameters
        //2. Reference Parameters
        //3. Output Parameters
        //4. Parameter arrays
        //Examples for all 4 types of method parameters.
        public static void ValueParameterExample(int num)
        {
            num += 10;
            Console.WriteLine("Inside ValueParameterExample, num: {0}", num);
        }
        public static void ReferenceParameterExample(ref int num)
        {
            int i = 0;
            simpleMethod(ref i);
            Console.WriteLine("Inside ReferenceParameterExample, num: {0}", i);
        }
        public static void simpleMethod(ref int j)
        {
            j = 101;
        }
        public static void OutputParameterExample(out int result)
        {
            result = 42; // Must assign a value before using the out parameter
            Console.WriteLine("Inside OutputParameterExample, result: {0}", result);
        }
        
        public static void ParameterArrayExample(params int[] numbers)
        {
            Console.WriteLine("Inside ParameterArrayExample, numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }   

    }
}