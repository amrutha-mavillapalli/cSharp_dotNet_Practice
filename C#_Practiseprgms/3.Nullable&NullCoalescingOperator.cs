namespace MyPractise
{
    public class ClsNullable
    {
        public static void NullableAndNullCoalescing()
        {
            // Nullable types
            int? nullableInt = null; // Can hold an int value or null
            bool? nullableBool = true; // Can hold a bool value or null 

            Console.WriteLine("nullableInt: {0}, nullableBool: {1}\n", nullableInt, nullableBool);

            // Null-coalescing operator
            int? possiblyNullInt = null;
            int defaultValue = 42;
            int result = possiblyNullInt ?? defaultValue; // If possiblyNullInt is null, use defaultValue
            Console.WriteLine("Result using null-coalescing operator: {0}\n", result);

            possiblyNullInt = 100;
            result = possiblyNullInt ?? defaultValue; // Now possiblyNullInt has a value
            Console.WriteLine("Result using null-coalescing operator: {0}\n",result);
        }
    }
}