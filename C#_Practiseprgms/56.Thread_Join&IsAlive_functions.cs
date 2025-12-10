namespace MyPractise
{
    public class ClsThreadJoinAndIsAliveFunctions
    {
        public static void Thread1Function()
        {
            Console.WriteLine("Thread 1 function started.");
            Thread.Sleep(5000); // Simulate some work with a 2-second sleep
            Console.WriteLine("Thread 1 function is about to rerun.");
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread 2 function started.");
        }


        public static void ThreadJoinAndIsAliveFunctionsExample()
        {
            Console.WriteLine("Main thread is starting.");
            Thread T1 = new Thread(new ThreadStart(Thread1Function));
            T1.Start();

            Thread T2 = new Thread(new ThreadStart(Thread2Function));
            T2.Start();
            // Main thread will wait until T1 completes
            if (T1.Join(1000))
            {
                Console.WriteLine("Thread 1 Function has completed.");
            }
            else
            {
                Console.WriteLine("Thread 1 Function has not completed within 1 second");
            }

            // Console.WriteLine("Thread 1 Function has completed. IsAlive: {0}", T1.IsAlive);
            T2.Join(); // Main thread will wait until T2 completes
            Console.WriteLine("Thread 2  Function has completed.");

            if (T1.IsAlive)
            {
                Console.WriteLine("Thread 1 is still running. IsAlive: {0}", T1.IsAlive);
            }
            else
            {
                Console.WriteLine("Thread 1 has completed. IsAlive: {0}", T1.IsAlive);
            }
            Console.WriteLine("Main thread is exiting.");
        }

    }
}