namespace MyPractise
{
    public class ClsWhileAndDoWhile
    {
        public static void loops()
        {
            // While loop example
            int count = 1;
            Console.WriteLine("While Loop:");
            while (count <= 5)
            {
                Console.WriteLine("Count: {0}", count);
                count++;
            }

            // Do-while loop example
            int doCount = 1;
            Console.WriteLine("\nDo-While Loop:");
            do
            {
                Console.WriteLine("DoCount: {0}", doCount);
                doCount++;
            } while (doCount <= 5);

            // For loop example
            Console.WriteLine("\nFor Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i: {0}", i);
            }
            // Foreach loop example
            Console.WriteLine("\nForeach Loop:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var num in numbers)
            {
                Console.WriteLine("Number: {0}", num);
            }
        }
    }
}