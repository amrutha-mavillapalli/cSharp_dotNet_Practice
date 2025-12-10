using System.Security.Cryptography.X509Certificates;

namespace MyPractise
{
    public class ClsDelegates1
    {
        // Step 1: Define a delegate type
        public delegate bool IsPromotable(Employee emp);
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public static void PromoteEmployee(List<Employee> empList, IsPromotable IsPromotable)
            {
                foreach (var emp in empList)
                {
                    if (IsPromotable(emp))
                    {
                        Console.WriteLine(emp.Name + " Promoted");
                    }
                }
            }
        }
        public static void DelegatesExample1()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "Amrutha", Salary = 5000, Experience = 6 });
            empList.Add(new Employee() { Id = 102, Name = "Kavitha", Salary = 6000, Experience = 5 });
            empList.Add(new Employee() { Id = 103, Name = "Sowmya", Salary = 7000, Experience = 3 });
            empList.Add(new Employee() { Id = 104, Name = "Anusha", Salary = 8000, Experience = 2 });

            //PromoteEmployee(empList, IsPromotable);
            IsPromotable isPromotable = new IsPromotable(IsEligibleForPromotion);
            Employee.PromoteEmployee(empList, isPromotable);
        }
        public static bool IsEligibleForPromotion(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }

    }
}