namespace MyPractise
{
    public class ClsOptional_parameter_specifyingdefault
    {
        public static void DisplayDetails(string name, int age = 18, string city = "Hyderabad")
        {
            Console.WriteLine("Name: {0}, Age: {1}, City: {2}", name, age, city);
        }

        public static void OptionalParametersSpecifyingDefaultExample()
        {
            // Calling method with all parameters
            DisplayDetails("Alice", 25, "New York");

            // Calling method with only the required parameter
            DisplayDetails("Bob");

            // Calling method with one optional parameter
            DisplayDetails("Charlie", 30);
        }

        //named parameters
        public static void NamedParametersExample()
        {
            // Calling method with named parameters
            DisplayDetails(name: "David", city: "Los Angeles");
            DisplayDetails(city: "Chicago", name: "Eve", age: 22);
        }
    }
}