namespace MyPractise
{
    public class ClsRetrieveDataFromThreadFuncUsingCallbackDelegate
    {
        // Define a delegate that matches the signature of the thread function
        public delegate void SumOfNumbersCallback(int SumOfNumbers);

        class Number
        {
            int _target;
            SumOfNumbersCallback _callback;

            public Number(int target, SumOfNumbersCallback callback)
            {
                this._target = target;
                this._callback = callback;
            }
            // This method will be executed in the thread
            public void PrintSumOfNumbers()
            {
                int sum = 0;
                for (int i = 1; i <= _target; i++)
                {
                    sum = sum + i;
                }
                // Invoke the callback with the computed sum
                if (_callback != null)
                    _callback(sum);
            }
        }
        // This method matches the delegate signature
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers is: {0}", sum);
        }

        public static void RetrieveDataFromThreadFuncUsingCallbackDelegateExample()
        {
            Console.WriteLine("Please enter the target number:");
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the delegate pointing to the PrintSum method
            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);
            Number number = new Number(target, callback);
            Thread T1 = new Thread(new ThreadStart(number.PrintSumOfNumbers));
            T1.Start();
        }
    }
}