namespace MyPractise
{
    public class ClsLambdaExpressions
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

        public void LambdaExpressionsExample()
        {
            Console.WriteLine("\nLambda Expressions Example\n");

            // Using Lambda Expression to find employees with Id equal to 102
            Employee employee = Listemployees.Find((Employee emp) => emp.Id == 102);
            Console.WriteLine("ID: {0}, Name: {1}", employee.Id, employee.Name);

            // Using Lambda Expression to find employees with Name equal to "Chandu"
            Employee employeeByName = Listemployees.Find(emp => emp.Name.StartsWith("C"));
            Console.WriteLine("ID: {0}, Name: {1}", employeeByName.Id, employeeByName.Name);

        }
    }
}