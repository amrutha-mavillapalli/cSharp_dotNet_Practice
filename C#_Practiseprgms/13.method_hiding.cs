namespace MyPractise
{
    public class ClsMethodHiding
    {
        public class Employee
        {
            public string firstName;
            public string lastName;

            public void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName);
            }

        }
        public class FullTimeEmployee : Employee
        {
            // it will show warning msg if u dont use 'new' keyword when method is hidden.
            // to avoid warning use 'new' keyword as below.
            public new void PrintFullName()
            {
                // base.PrintFullName(); // to call base class method using 'base' keyword

                Console.WriteLine(firstName + " " + lastName + " - Contractor");
                
            }

        }
        public class PartTimeEmployee : Employee
        {
            public new void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName + " - PartTimeEmployee");
            }
        }
       
        public static void MethodHidingExample()
        {
            Console.WriteLine("Method Hiding Example:");
            Console.WriteLine();
            FullTimeEmployee fte = new FullTimeEmployee();
            //Employee fte = new FullTimeEmployee(); // base class reference and derived class object
            fte.firstName = "FullTime";
            fte.lastName = "Employee";
            //fte.PrintFullName();

            ((Employee)fte).PrintFullName(); // calling base class method using casting

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstName = "PartTime";
            pte.lastName = "Employee";
            pte.PrintFullName();

            Console.WriteLine();
        }
    }
}