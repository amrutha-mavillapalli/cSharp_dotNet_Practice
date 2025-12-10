namespace MyPractise
{
    public class ClsListGenericClassesAndRanges
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public string Type { get; set; }
        }
        public static void ListGenericClassesAndRangesExample()
        {
            // Create customer objects
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Mark", Salary = 4000, Type = "RetailCustomer" };
            ClsCustomer cust2 = new ClsCustomer() { Id = 2, Name = "Pam", Salary = 7000, Type = "RetailCustomer" };
            ClsCustomer cust3 = new ClsCustomer() { Id = 3, Name = "Rob", Salary = 5500, Type = "RetailCustomer" };
            ClsCustomer cust4 = new ClsCustomer() { Id = 4, Name = "John", Salary = 6500, Type = "CorporateCustomer" };
            ClsCustomer cust5 = new ClsCustomer() { Id = 5, Name = "Sam", Salary = 3500, Type = "CorporateCustomer" };

            List<ClsCustomer> ListCustomers = new List<ClsCustomer>();
            ListCustomers.Add(cust1);
            ListCustomers.Add(cust2);
            ListCustomers.Add(cust3);

            List<ClsCustomer> ListCorporateCustomers = new List<ClsCustomer>();
            ListCorporateCustomers.Add(cust4);
            ListCorporateCustomers.Add(cust5);

            //AddRange() function
            ListCustomers.AddRange(ListCorporateCustomers);
            foreach (ClsCustomer c in ListCustomers)
            {
                Console.WriteLine("ID={0}, Name={1}, Salary = {2}, Type={3}", c.Id, c.Name, c.Salary, c.Type);
            }

            //GetRange() function
            List<ClsCustomer> customers = ListCustomers.GetRange(0, 3);
            foreach (ClsCustomer c in customers)
            {
                Console.WriteLine("ID={0}, Name={1}, Salary = {2}, Type={3}", c.Id, c.Name, c.Salary, c.Type);
            }
            //Remove,removeAt,RemoveAll,removeRange() functions
            // ListCustomers.Remove(cust1);
            // ListCustomers.RemoveAt(4);
            // ListCustomers.RemoveAll(x => x.Type == "CorporateCustomer");
            ListCustomers.RemoveRange(3, 2);//remove corporate customers

            //InsertRange() function
            ListCustomers.InsertRange(0, ListCorporateCustomers);
            foreach (ClsCustomer c in ListCustomers)
            {
                Console.WriteLine("ID={0}, Name={1}, Salary = {2}, Type={3}", c.Id, c.Name, c.Salary, c.Type);
            }
        }
    }
}