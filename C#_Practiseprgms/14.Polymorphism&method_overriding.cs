namespace MyPractise
{
    public class ClsPolymorphism
    {
        // Base class
        public class Employee
        {
            public string firstName = "FN";
            public string lastName = "LN";

            // Making the method virtual to allow overriding in derived classes
            public virtual void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName);
            }

        }
        public class FullTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName + " - Full Time Employee");
            }
        }
        public class PartTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName + " - Part Time Employee");
            }
        }
        public class TemporaryEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName + " - Temporary Employee");
            }

        }

        public static void PolymorphismExample()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();
            foreach (var emp in employees)
            {
                emp.PrintFullName(); // Calls the appropriate PrintFullName method based on the object type
            }
            Console.WriteLine();
        }
    }
}
// Output:
// FN LN
// FN LN - Full Time Employee
// FN LN - Part Time Employee       
// FN LN - Temporary Employee
// Explanation:
// In this example, we have a base class Employee with a virtual method PrintFullName.
// The derived classes FullTimeEmployee, PartTimeEmployee, and TemporaryEmployee override this method to provide their specific implementations.
// In the PolymorphismExample method, we create an array of Employee references, each pointing to different types of employee objects.
// When we call PrintFullName on each object, the appropriate overridden method is invoked based on the actual object type, demonstrating polymorphism. 
// This allows for dynamic method resolution at runtime, enabling flexible and extensible code.
// Note: If the PrintFullName method in the base class is not marked as virtual, the derived classes cannot override it, and the base class method will always be called, regardless of the object type.
// Similarly, if the derived classes do not use the override keyword, they will hide the base class method instead of overriding it, leading to different behavior.
