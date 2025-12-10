namespace MyPractise
{
    public class ClsPassDataToThreadTypesafe
    {
        public class Numbers
        {
            private int _target;
            public Numbers(int target)
            {
                this._target = target;
            }
            public void PrintNumbers()
            {
                for (int i = 1; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void ThreadFunctionPassingDataTypesafeExample()
        {
            Console.WriteLine("Please enter the target number:");
            int target = Convert.ToInt32(Console.ReadLine());

            ClsPassDataToThreadTypesafe.Numbers passDataToThread = new ClsPassDataToThreadTypesafe.Numbers(target);
            Thread T1 = new Thread(new ThreadStart(passDataToThread.PrintNumbers));
            T1.Start();


        }
    }

}

