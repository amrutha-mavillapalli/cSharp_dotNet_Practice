namespace MyPractise
{
    public class ClsAnonymousMethods
    {
        // Define a simple Employee class with Id and Name properties
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
        // Create a list of employees
       List<Employee> Listemployees = new List<Employee>()
        {
            new Employee(){ Id=101, Name="Amrutha"},
            new Employee(){ Id=102, Name="Bala"},
            new Employee(){ Id=103, Name="Chandu"}
           
        };

        public void AnonymousMethodExample()
        {
            Console.WriteLine("\nAnonymous Method Example\n");

            // Using Anonymous Method to find employees with Id equal to 102
            Employee employee = Listemployees.Find(delegate (Employee emp)
            {
                return emp.Id == 102;
            });

            
                Console.WriteLine("ID: {0}, Name: {1}", employee.Id, employee.Name);
            
        }
    }
}