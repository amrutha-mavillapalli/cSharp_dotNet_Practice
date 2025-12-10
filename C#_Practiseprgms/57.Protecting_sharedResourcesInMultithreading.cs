using System.Diagnostics;

namespace MyPractise
{
    public class ClsProtectingSharedResourcesInMultithreading
    {
        static int Total = 0;
        // static  object _lock = new object();
        public static void AddOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // using lock to protect the shared resource
                // lock (_lock)
                // {
                //     Total++;
                // }
                // Using Interlocked to protect the shared resource
                Interlocked.Increment(ref Total);
                // Total++;
            }
        }

        public static void ProtectingSharedResourcesInMultithreadingExample()
        {
            // Without using threads, the Total will always be 3000000
            AddOneMillion();
            AddOneMillion();
            AddOneMillion();
            Console.WriteLine("Total in single thread is: {0}", Total);

            // When we use threads, the Total may not be 3000000 because of race conditions
            Total = 0; // Reset Total to 0
            Stopwatch stopwatch = Stopwatch.StartNew();
            // But when we use threads
            Thread T1 = new Thread(new ThreadStart(AddOneMillion));
            Thread T2 = new Thread(new ThreadStart(AddOneMillion));
            Thread T3 = new Thread(new ThreadStart(AddOneMillion));
            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine("Total is: {0}", Total);
            stopwatch.Stop();
            Console.WriteLine("Time taken with threads: {0} ms", stopwatch.ElapsedMilliseconds);
        }

    }
}