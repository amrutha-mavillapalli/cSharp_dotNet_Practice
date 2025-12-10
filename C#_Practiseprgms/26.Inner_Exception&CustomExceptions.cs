namespace MyPractise
{
    public class ClsInnerExceptionAndCustomExceptions
    {
        public static void InnerExceptionExample()
        {
            try
            {
                try
                {
                    int[] numbers = { 1, 2, 3 };
                    // This will cause an IndexOutOfRangeException
                    Console.WriteLine(numbers[5]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    // Wrap the caught exception in a new exception
                    throw new Exception("An error occurred while accessing the array.", ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer Exception: " + ex.Message);
                ex.GetType();
                Console.WriteLine("Exception Type: " + ex.GetType().ToString());
                // Check if there is an inner exception and print its message
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }
        // Custom exception class
        public class UserAlreadyLoggedInException : Exception
        {
            public UserAlreadyLoggedInException() : base()
            {
            }
            public UserAlreadyLoggedInException(string message) : base(message)
            {
            }
            public UserAlreadyLoggedInException(string message, Exception inner) : base(message, inner)
            {
            }
            public UserAlreadyLoggedInException(System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context)
            {
            }


        }
        public static void CustomExceptionExample()
        {
            try
            {
                // Simulate a scenario where a user is already logged in
                bool isUserLoggedIn = true;
                if (isUserLoggedIn)
                {
                    throw new UserAlreadyLoggedInException("User is already logged in.");
                }
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
        }
    }

}