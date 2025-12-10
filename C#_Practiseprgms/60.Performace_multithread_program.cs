using System.Diagnostics;

namespace MyPractise
{
    public class ClsPerformaceMultiThread
    {
        public static void EvenNumberSum()
        {
            double Sum = 0;
            for (int i = 0; i < 20000000; i++)
            {
                if (i % 2 == 0)
                    Sum += i;
            }
            Console.WriteLine("Sum of even numbers: {0}", Sum);

        }

        public static void OddNumberSum()
        {
            double Sum = 0;
            for (int i = 0; i < 20000000; i++)
            {
                if (i % 2 != 0)
                    Sum += i;
            }
            Console.WriteLine("Sum of odd numbers: {0}", Sum);

        }
        public static void PerformanceMultiThreadExample()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            EvenNumberSum();
            OddNumberSum();
            stopwatch.Stop();
            Console.WriteLine("Total milliseconds without multi-threading: {0} ms", stopwatch.ElapsedMilliseconds);

            Stopwatch sw = Stopwatch.StartNew();
            Thread T1 = new Thread(new ThreadStart(EvenNumberSum));
            Thread T2 = new Thread(new ThreadStart(OddNumberSum));
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            sw.Stop();
            Console.WriteLine("Total milliseconds with multi-threading: {0} ms", sw.ElapsedMilliseconds);

        }

    }

}