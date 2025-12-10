namespace MyPractise
{
    public class ClsBuiltIn
    {
        public static void BuiltinTypes()
        {
            //Integral types
            byte b = 255; //1 byte 0 to 255
            sbyte sb = -128; //1 byte -128 to 127
            short s = -32768; //2 bytes -32,768 to 32,767
            ushort us = 65535; //2 bytes 0 to 65,535
            int i = -2147483648; //4 bytes -2,147,483,648 to 2,147,483,647
            uint ui = 4294967295; //4 bytes 0 to 4,294,967,295
            long l = -9223372036854775808; //8 bytes -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong ul = 18446744073709551615; //8 bytes 0 to 18,446,744,073,709,551,615

            //Floating point types
            float f = 3.402823e38F; //4 bytes ±1.5e−45 to ±3.4e38 (7 digits precision)
            double d = 123.34344535; //8 bytes ±5.0e−324 to ±1.7e308 (15-16 digits precision)
            decimal dec = 79228162514264337593543950335M; //16 bytes ±1.0 x 10^-28 to ±7.9 x 10^28 (28-29 digits precision)

            //Other types
            char c = 'A'; //2 bytes Unicode character
            bool bo = true; //1 byte true or false

            //Non-primitive types
            string str = "Hello, World!"; //A sequence of characters
            object obj = new object(); //Base type of all other types

            // Implicitly typed variable
            var implicitInt = 42; // The compiler infers the type as int
            var implicitString = "Implicitly typed string"; // The compiler infers the type as string

            // Nullable types
            int? nullableInt = null; // Can hold an int value or null
            bool? nullableBool = true; // Can hold a bool value or null 

            Console.WriteLine($"byte: {b}, sbyte: {sb}, short: {s}, ushort: {us}, int: {i}, uint: {ui}, long: {l}, ulong: {ul}");
            Console.WriteLine($"float: {f}, decimal: {dec}, char: {c}, bool: {bo}");
            Console.WriteLine($"string: {str}, object: {obj}");
            Console.WriteLine($"implicitInt: {implicitInt}, implicitString: {implicitString}");
            Console.WriteLine($"nullableInt: {nullableInt}, nullableBool: {nullableBool}\n");


            // int i  =0;
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Min = {0}\n", int.MaxValue);
            Console.WriteLine(d);

            string name = "\"Amrutha\"";  // Escape sequence for double quotes
            Console.WriteLine(name);

            // Displaying new line character in c#
            string Name = "\nOne\nTwo\nThree";
            Console.WriteLine(Name);
            // Displaying link without verbatim literal 
            Name = "c:\\Pragim\\DotNet\\Training\\Csharp";  //less readable
            Console.WriteLine(Name);
            // C# verbatim literal
            Name = @"c:\Pragim\DotNet\Training\Csharp";   // more readable
            Console.WriteLine(Name);

        }
    }
}