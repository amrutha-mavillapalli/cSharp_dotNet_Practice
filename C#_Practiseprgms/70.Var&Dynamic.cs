namespace MyPractise
{
    public class ClsVarAndDynamic
    {
        public static void VarAndDynamicExample()
        {
            // Using var
            var number = 10; // Implicitly typed as int
            Console.WriteLine("Var example: " + number);

            // Using dynamic
            dynamic text = "Hello, World!";
            Console.WriteLine("Dynamic example: " + text);

            // Changing the type of dynamic variable
            text = 100;
            Console.WriteLine("Dynamic example after changing type: " + text);
        }
    }
}