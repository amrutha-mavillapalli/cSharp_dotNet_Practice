namespace MyPractise
{
    public class ClsStringVsStringBuilder
    {
        public static void StringVsStringBuilderExample()
        {
            // Using string (immutable)
            string str = "Hello";
            Console.WriteLine("Original string: " + str);
            str += " World"; // Creates a new string
            Console.WriteLine("After concatenation: " + str);

            // Using StringBuilder (mutable)
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello");
            Console.WriteLine("Original StringBuilder: " + sb.ToString());
            sb.Append(" World"); // Modifies the existing StringBuilder
            Console.WriteLine("After appending: " + sb.ToString());
        }
    }
}