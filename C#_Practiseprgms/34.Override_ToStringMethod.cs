namespace MyPractise
{
    public class ClsOverrideToStringMethod
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Override ToString method
            public override string ToString()
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public static void OverrideToStringExample()
        {
            int num = 10;
            Console.WriteLine(num.ToString());

            // Using overridden ToString method
            // without overriding ToString method it will print the namespace.classname. So we override it to print meaningful information.
            Person person = new Person { FirstName = "Amrutha", LastName = "Mavillapalli" };
            Console.WriteLine(person.ToString());
        }
    }
}