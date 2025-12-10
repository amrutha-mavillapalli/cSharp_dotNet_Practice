namespace MyPractise
{
    public class ClsThreadStartDelegate
    {
        public class Numbers
        {
            public void PrintNumbers()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void ThreadStartDelegateExample()
        {
            Numbers Numbers = new Numbers();
            Thread T1 = new Thread(new ThreadStart(Numbers.PrintNumbers));
            T1.Start();

        }
    }
}