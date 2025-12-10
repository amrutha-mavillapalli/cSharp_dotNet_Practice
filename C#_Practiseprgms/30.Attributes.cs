namespace MyPractise
{
    public class ClsAttributes
    {
      
        public class Calculator
        {
            // Using Built-in Attribute to mark method as obsolete
            // Use of Obsolete Attribute when the method is outdated
            [Obsolete("Use Add(int a, int b) instead.")]

            //[Obsolete("Use Add(int a, int b) instead.", true)] // This will cause a compile-time error if used 
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(List<int> numbers)
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
        }

        public static void AttributesExample()
        {
            Calculator calc = new Calculator();
            int result1 = calc.Add(5, 10); // This will show a warning
            Console.WriteLine("Result of Add(5, 10): " + result1);
            // This is the preferred method
            int result2 = calc.Add(new List<int> { 1, 2, 3, 4, 5 }); 
            Console.WriteLine("Result of Add(List<int>): " + result2);
        }
    }       
}