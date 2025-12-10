using System.Collections.ObjectModel;

namespace MyPractise
{
    public class ClsListMethods
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public static void ListMethodsExample()
        {
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Salary = 4000 };
            ClsCustomer cust2 = new ClsCustomer() { Id = 3, Name = "Bob", Salary = 7000 };
            ClsCustomer cust3 = new ClsCustomer() { Id = 2, Name = "Charlie", Salary = 5500 };

            List<ClsCustomer> customersList = new List<ClsCustomer>(100);
            customersList.Add(cust1);
            customersList.Add(cust2);
            customersList.Add(cust3);

            //TrueForAll() method
            Console.WriteLine("Are all salaries greater than 3000 = " +
            customersList.TrueForAll(x => x.Salary > 3000));
            Console.WriteLine("Are all salaries greater than 5000 = " +
            customersList.TrueForAll(x => x.Salary > 5000));

            //ReadOnly() method
            ReadOnlyCollection<ClsCustomer> readonlycustomer = customersList.AsReadOnly();
            Console.WriteLine("readonly Items = " + readonlycustomer.Count);

            //TrimAccess() method
            //have given 100 as list size while creating
            Console.WriteLine("Capacity before Trimming = " + customersList.Capacity);
            customersList.TrimExcess();
            Console.WriteLine("Capacity after Trimming = " + customersList.Capacity);




        }

    }
}