namespace MyPractise
{
    public class ClsGenerics
    {
        // Generic method
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }


        // Generic class
        public class GenericClass<T>
        {
            private T genericField;
            // Constructor
            public GenericClass(T value)
            {
                genericField = value;
            }
            // Method to get the value of the generic field
            public T GetGenericField()
            {
                return genericField;
            }

        }

        public static void GenericsExample()
        {
            ClsGenerics generics = new ClsGenerics();

            // Using generic method
            bool Equal1 = AreEqual<int>(10, 10);
            bool Equal2 = AreEqual<string>("Hello Generics", "Hello Generics");
            if (Equal1 && Equal2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");

            // Using generic class  
            GenericClass<int> genericInstanceInt = new GenericClass<int>(100);
            Console.WriteLine("Generic Class field value: " + genericInstanceInt.GetGenericField());    
            GenericClass<string> genericInstanceStr = new GenericClass<string>("Generics in C#");
            Console.WriteLine("Generic Class field value: " + genericInstanceStr.GetGenericField());
            GenericClass<double> genericInstance = new GenericClass<double>(3.14);
            Console.WriteLine("Generic Class field value: " + genericInstance.GetGenericField());

        }
    }
}