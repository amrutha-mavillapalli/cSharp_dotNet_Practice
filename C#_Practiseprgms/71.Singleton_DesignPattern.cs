using System;

namespace MyPractise
{
    public class ClsSingleton
    {
        public sealed class Singleton
        {
            // Static variable to hold the single instance
            public static int InstanceCount = 0;
            // Private property initilized with null
            // ensures that only one instance of the object is created
            // based on the null condition
            private static Singleton instance = null;
            private static readonly object lockObject = new object();

            //public property is used to return only one instance of the class
            // leveraging on the private property
            public static Singleton GetInstance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (lockObject)
                        {
                            if (instance == null)
                                instance = new Singleton();
                        }
                    }
                    return instance;
                }
            }
            // Private constructor to prevent instantiation from outside
            private Singleton()
            {
                // Private constructor to prevent instantiation from outside
                ++InstanceCount;
                Console.WriteLine("Singleton Instance Count: " + InstanceCount);

            }
            // Example method to demonstrate functionality
            public void ShowMessage()
            {
                Console.WriteLine("Hello from Singleton!");
            }
        }
        public static void SingletonExample()
        {
            // Attempting to create multiple instances
            Singleton s1 = Singleton.GetInstance;
            s1.ShowMessage();

            Singleton s2 = Singleton.GetInstance;
            s2.ShowMessage();

            Singleton s3 = Singleton.GetInstance;
            s3.ShowMessage();

            // All instances should be the same
            Console.WriteLine("Are all instances the same? " + (s1 == s2 && s2 == s3));
        }
    }
}