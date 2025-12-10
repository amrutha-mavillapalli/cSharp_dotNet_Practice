namespace MyPractise
{
    public class ClsListSortingForComplexTypes_comparionDelegate
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
        //commenting the method to achieve it in another approach
        // private static int CompareCustomer(ClsCustomer x, ClsCustomer y)
        // {
        //     return x.Id.CompareTo(y.Id);
        // }
        public static void ListSortingForComplexTypesComparionDelegateExample()
        {
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Salary = 4000 };
            ClsCustomer cust2 = new ClsCustomer() { Id = 3, Name = "Bob", Salary = 7000 };
            ClsCustomer cust3 = new ClsCustomer() { Id = 2, Name = "Charlie", Salary = 5500 };

            List<ClsCustomer> customersList = new List<ClsCustomer>(2);
            customersList.Add(cust1);
            customersList.Add(cust2);
            customersList.Add(cust3);

            // Comparison<ClsCustomer> comparison = new Comparison<ClsCustomer>(CompareCustomer);
            Console.WriteLine("Before Sorting:");
            foreach (ClsCustomer c in customersList)
            {
                Console.WriteLine(c.Id);
            }
            // customersList.Sort(CompareCustomer);  //approach1
            //approach2
            // customersList.Sort(delegate (ClsCustomer x, ClsCustomer y)
            // {
            //     return x.Id.CompareTo(y.Id);

            // });
            //approach 3
            customersList.Sort((x,y)=>x.Id.CompareTo(y.Id));

            Console.WriteLine("After Sorting:");
            foreach (ClsCustomer c in customersList)
            {
                Console.WriteLine(c.Id);
            }

        }
    }

}