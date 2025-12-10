namespace MyPractise
{
    public class ClsParameterizedThreadStartDelegate
    {
        public class Numbers
        {
            public void PrintNumbers(object target)
            {
                int number = 0;
                if (int.TryParse(target.ToString(), out number))
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public static void ParameterizedThreadStartDelegateExample()
        {
            Console.WriteLine("Please enter the target number:");
             object target = Console.ReadLine();
            Numbers Numbers = new Numbers();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Numbers.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(target); // Passing target to print

            // Console.WriteLine("Please enter the target number:");
            // object target = Console.ReadLine();
            // Thread T2 = new Thread(Numbers.PrintNumbers);
            // T2.Start(target); 
        }
    }
}