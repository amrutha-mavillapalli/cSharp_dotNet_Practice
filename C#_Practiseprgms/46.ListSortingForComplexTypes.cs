namespace MyPractise
{
    public class ClsListSortingForComplexTypes
    {
        public class ClsCustomer : IComparable<ClsCustomer>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public int CompareTo(ClsCustomer other)
            {
                // sort using salary
                return this.Salary.CompareTo(other.Salary);
                //sort using name
                // return this.Name.CompareTo(other.Name);
                //either use above code line or we can create our own as below
            }
        }
        //another way to sort by using name
        public class SortByName : IComparer<ClsCustomer>
        {
            public int Compare(ClsCustomer x, ClsCustomer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public static void ListSortingForComplexTypesExample()
        {
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Salary = 4000 };
            ClsCustomer cust2 = new ClsCustomer() { Id = 2, Name = "Bob", Salary = 7000 };
            ClsCustomer cust3 = new ClsCustomer() { Id = 3, Name = "Charlie", Salary = 5500 };

            List<ClsCustomer> customersList = new List<ClsCustomer>(2);
            customersList.Add(cust1);
            customersList.Add(cust2);
            customersList.Add(cust3);

            Console.WriteLine("Before Sorting:");
            foreach (ClsCustomer c in customersList)
            {
                Console.WriteLine(c.Salary);
            }
            customersList.Sort();
            customersList.Reverse();
            Console.WriteLine("After Sorting:");
            foreach (ClsCustomer c in customersList)
            {
                Console.WriteLine(c.Salary);
            }

            SortByName sortByName = new SortByName();
            customersList.Sort(sortByName);
            Console.WriteLine("After Sorting:");
            foreach (ClsCustomer c in customersList)
            {
                Console.WriteLine(c.Name);
            }

        }

    }
}