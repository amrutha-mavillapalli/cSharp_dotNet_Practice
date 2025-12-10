namespace MyPractise
{
    public class ClsOperators
    {
        public static void Operators()
        {
            int a = 10;
            int b = 20;

            // Arithmetic Operators
            Console.WriteLine("\nArithmetic Operators:");
            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("Subtraction: {0} - {1} = {2}", b, a, b - a);
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {b} / {a} = {b / a}");
            Console.WriteLine($"Modulus: {b} % {a} = {b % a}");

            // Comparison Operators
            Console.WriteLine("\nComparison Operators:");
            Console.WriteLine("{0} == {1}: {2}", a, b, a == b);
            Console.WriteLine("{0} != {1}: {2}", a, b, a != b);
            Console.WriteLine("{0} > {1}: {2}", a, b, a > b);
            Console.WriteLine("{0} < {1}: {2}", a, b, a < b);
            Console.WriteLine($"{a} >= {b}: {a >= b}");
            Console.WriteLine($"{a} <= {b}: {a <= b}");

            // Logical/conditional Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine("{0} && {1}: {2}", x, y, x && y);
            Console.WriteLine($"{x} || {y}: {x || y}");
            Console.WriteLine($"!{x}: {!x}");

            // Assignment Operators
            int c = a; // Simple assignment
            c += b; // c = c + b
            Console.WriteLine("\nAssignment Operators:");
            Console.WriteLine($"c after += : {c}");
            c -= a; // c = c - a
            Console.WriteLine($"c after -= : {c}");
            c *= 2; // c = c * 2
            Console.WriteLine($"c after *= : {c}");
            c /= 2; // c = c / 2
            Console.WriteLine($"c after /= : {c}");
            c %= 3; // c = c % 3
            Console.WriteLine($"c after %= : {c}");

            // Increment and Decrement Operators
            Console.WriteLine("\nIncrement and Decrement Operators:");
            Console.WriteLine("a before increment: {0}", a);
            Console.WriteLine("a after increment: {0}", a++);
            Console.WriteLine("b before decrement: {0}", b);
            Console.WriteLine("b after decrement: {0}\n", --b);


            // Ternary operator example
             int number = 10;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", isNumber10);

        }
    }
}