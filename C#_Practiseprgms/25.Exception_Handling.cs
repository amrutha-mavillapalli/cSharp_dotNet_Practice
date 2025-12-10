namespace MyPractise
{
    public class ClsExceptionHandling
    {
        public static void ExceptionHandlingExample()
        {
          
            // Example of handling file I/O exceptions
             StreamReader reader = null;

            try
            {
                reader = new StreamReader("nonexistentfile.txt");
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            // Catch specific exceptions first
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Access to the file is denied. " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: The file was not found. " + ex.FileName);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: An I/O error occurred. " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close(); // Ensure the file is closed after reading
                }
                Console.WriteLine("Finally Block.");
            }
        }
    }
}