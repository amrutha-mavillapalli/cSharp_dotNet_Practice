namespace MyPractise
{
    public class ClsFunctionDelegate
    {
        // Define a simple Employee class with Id and Name properties
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
        public static void FunctionDelegateExample()
        {
            // Create a list of employees
            List<Employee> Listemployees = new List<Employee>()
            {
            new Employee(){ Id=101, Name="Amrutha"},
            new Employee(){ Id=102, Name="Bala"},
            new Employee(){ Id=103, Name="Chandu"}};
            // Define a Func delegate that takes an Employee and returns a string (the employee's name)
            Func<Employee, string> getEmployeeName = emp => "Name: " + emp.Name;
            // employeeNames will hold the names of all employees in the list
            IEnumerable<string> employeeNames = Listemployees.Select(getEmployeeName);
            foreach (string name in employeeNames)
            {
                Console.WriteLine(name);
            }
        }
        // Function delegate with multiple parameters example
        public static void FunctionDelegateWithMultipleParametersExample()
        {
            // Define a Func delegate that takes two integers and returns their sum
            Func<int, int, int> add = (x, y) => x + y;
            int result = add(10, 20);
            Console.WriteLine("Sum: " + result);
        }
    }
}