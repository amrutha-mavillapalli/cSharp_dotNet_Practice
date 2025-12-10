namespace MyPractise
{
    public class ClsAsyncAndAwait
    {
        // Simulate a time-consuming operation
        public static async Task<string> TimeConsumingOperationAsync()
        {
            await Task.Delay(3000); // Simulate a 3-second delay
            return "Operation Completed";
        }

        public static async Task AsyncAndAwaitExample()
        {
            Console.WriteLine("Starting the time-consuming operation...");

            // Await the asynchronous operation
            string result = await TimeConsumingOperationAsync();

            Console.WriteLine(result);
        }
    }
}