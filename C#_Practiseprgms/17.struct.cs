namespace MyPractise
{
    public class ClsStruct
    {
        public struct Employee
        {
            public int Id;
            public string Name;
            // Constructor
            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public void PrintEmployee()
            {
                Console.WriteLine("Employee Id: {0}, Name: {1}", Id, Name);
            }
        }

        public static void StructExample()
        {
            Employee E1 = new Employee(1, "Amrutha"); // Create an instance of the struct
            E1.PrintEmployee(); // Call the method to print employee details

            Employee E2 = new Employee(); // Create an instance of the struct
            // E2.Id = 2;
            // E2.Name = "Mavillapalli";
            E2.PrintEmployee(); // Call the method to print employee details

            Employee E3 = new Employee
            {
                Id = 3,
                Name = "Test"
            }; // Create an instance of the struct
            E3.PrintEmployee(); 
        }
    }
}