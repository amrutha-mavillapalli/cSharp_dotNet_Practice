using System.Reflection.Metadata.Ecma335;

namespace MyPractise
{
    public class ClsMulticastDelegates
    {
        // Step 1: Define a delegate type
        public delegate void SampleDelegate();

        // Step 2: Create methods that match the delegate signature
        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method One Executed");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method Two Executed");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three Executed");
        }

        // Step 3: Method to demonstrate multicast delegate usage
        public static void MulticastDelegateExample()
        {
            // Instantiate the delegate with the EmailNotification method
            SampleDelegate del = new SampleDelegate(SampleMethodOne);

            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodTwo; // Remove SampleMethodTwo from the invocation list

            // Invoke the multicast delegate
            del();
        }

        // deligate with return type
        public delegate int SampleDelegateWithReturn(int num);
        public static int SampleMethodWithReturn(int num)
        {
            return 1;
        }
        public static int SampleMethodWithReturn1(int num)
        {
            return 2;
        }
        public static void MulticastDelegateWithReturnExample()
        {
            // Instantiate the delegate with the SampleMethodWithReturn method
            SampleDelegateWithReturn del = new SampleDelegateWithReturn(SampleMethodWithReturn);

            del += SampleMethodWithReturn1;

            // Invoke the multicast delegate
            int result = del(5); // Only the return value of the last method will be returned
            Console.WriteLine("Final Result from Multicast Delegate with return : {0}", result);
        }
        // Multicast delegate with out parameters
        public delegate void SampleDelegateWithOut(out int result);
        public static void SampleMethodWithOut(out int result)
        {
            result = 1;
        }
        public static void SampleMethodWithOut1(out int result)
        {
            result = 2;
        }
        public static void MulticastDelegateWithOutExample()
        {
            // Instantiate the delegate with the SampleMethodWithOut method
            SampleDelegateWithOut del = new SampleDelegateWithOut(SampleMethodWithOut);
            del += SampleMethodWithOut1;
            int finalResult;
            // Invoke the multicast delegate
            del(out finalResult); // Only the out parameter of the last method will
            Console.WriteLine("Final Result from Multicast Delegate with Out: {0}", finalResult);
        }
    }
}