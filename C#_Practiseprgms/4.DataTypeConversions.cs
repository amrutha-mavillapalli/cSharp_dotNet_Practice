namespace MyPractise
{
    public class ClsDataTypeConversions
    {
        public static void DataTypeConversions()
        {
            // Implicit conversion (no data loss)
            int intValue = 123;
            double doubleValue = intValue; // int to double
            Console.WriteLine("Implicit Conversion: int {0} to double {1}", intValue, doubleValue);

            // Explicit conversion (possible data loss)
            double anotherDoubleValue = 123.45;
            int anotherIntValue = (int)anotherDoubleValue; // double to int WE ARE Explicitly converting
            Console.WriteLine("Explicit Conversion: double {0} to int {1}", anotherDoubleValue, anotherIntValue);

            // Using Convert class
            string strNumber = "456";
            int convertedInt = Convert.ToInt32(strNumber);
            Console.WriteLine("Using Convert class: string '{0}' to int {1}", strNumber, convertedInt);

            // Using Parse method
            string strFloat = "789.01";
            float parsedFloat = float.Parse(strFloat);
            Console.WriteLine("Using Parse method: string '{0}' to float {1}", strFloat, parsedFloat);

            // Using TryParse method
            string invalidNumber = "abc";
            bool isParsed = int.TryParse(invalidNumber, out int result);
            if (isParsed)
            {
                Console.WriteLine("TryParse succeeded: string '{0}' to int {1}", invalidNumber, result);
            }
            else
            {
                Console.WriteLine("TryParse failed: '{0}' is not a valid integer.\n", invalidNumber);
            }
        }
    }
}   