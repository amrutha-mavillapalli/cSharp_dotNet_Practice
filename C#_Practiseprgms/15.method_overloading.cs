namespace MyPractise
{
    public class ClsMethodOverloading
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void Add(int FN, int SN, out int result)
        {
            result = FN + SN;
        }   
        public static void MethodOverloadingExample()
        {
            Console.WriteLine("Method Overloading Example:");
            Console.WriteLine();

            int intSum1 = Add(10, 20);
            Console.WriteLine("Sum of two integers: {0}", intSum1);

            double doubleSum = Add(10.5, 20.3);
            Console.WriteLine("Sum of two doubles: {0}", doubleSum);

            int intSum2 = Add(10, 20, 30);
            Console.WriteLine("Sum of three integers: {0}", intSum2);
            int outSum;
            Add(15, 25, out outSum);
            Console.WriteLine("Sum using out parameter: {0}", outSum);

            Console.WriteLine();
        }
    }
}