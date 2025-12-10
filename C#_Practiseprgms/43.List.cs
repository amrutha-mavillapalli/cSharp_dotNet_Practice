namespace MyPractise
{
    public class ClsList
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public static void ListExample()
        {
            // Create customer objects
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Salary = 4000 };
            ClsCustomer cust2 = new ClsCustomer() { Id = 2, Name = "Bob", Salary = 7000 };
            ClsCustomer cust3 = new ClsCustomer() { Id = 3, Name = "Charlie", Salary = 5500 };

            List<ClsCustomer> customersList = new List<ClsCustomer>(2);
            customersList.Add(cust1);
            customersList.Add(cust2);
            customersList.Add(cust3);

            // access an element in list
            ClsCustomer cust = customersList[0];
            // Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            //access elements using for loop
            for (int i = 0; i < customersList.Count; i++)
            {
                ClsCustomer c = customersList[i];
                Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            }

            //if we want to insert the customer 3 in index 0 then
            customersList.Insert(0, cust1);

            //view the id's
            foreach (ClsCustomer c in customersList)
            {
                Console.WriteLine(c.Id);
            }

            //if we want to find the index of cutomer then we can use IndexOf function
            Console.WriteLine(customersList.IndexOf(cust3)); //bydefauly we will get the first element that matches

            // if i want to get the index of customer from the index value that i need 
            //then we will get the position of customer from index 1 in below ex.
            //IndexOF(cutsomer item, int index)
            Console.WriteLine(customersList.IndexOf(cust3, 1));

            // the 3rd attribute in the postion is count specifies the no of items to look
            //So, from index position 1 we are going to look for next 2 indexes
            //if we don't have cust3 then we will get -1 else it will give the position of index.
            //IndexOF(cutsomer item, int index, int count)
            Console.WriteLine(customersList.IndexOf(cust3, 1, 2));
            Console.WriteLine(customersList.IndexOf(cust3, 1, 3));

            //contains() function
            if (customersList.Contains(cust2))
            {
                Console.WriteLine("customer 2 object exists in the list");
            }
            else
            {
                Console.WriteLine("customer 2 object doesn't exists in the list");
            }

            //Exists() function, we can use lambda expression
            if (customersList.Exists(cust => cust.Name.StartsWith("B")))
            {
                Console.WriteLine("customer name starts with B  exists in the list");
            }
            else
            {
                Console.WriteLine("customer name starts with B  doesn't exists in the list");
            }

            //find() function
            ClsCustomer findcust = customersList.Find(cus => cus.Salary > 5000);
            Console.WriteLine("ID={0},Name={1},Salary={2}", findcust.Id, findcust.Name, findcust.Salary);

            //findLast() function
            ClsCustomer findlastcustomer = customersList.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine("ID={0},Name={1},Salary={2}", findlastcustomer.Id, findlastcustomer.Name, findlastcustomer.Salary);

            //findall() function
            List<ClsCustomer> customer1 = customersList.FindAll(cus => cus.Salary > 5000);
            foreach (var i in customer1)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}", i.Id, i.Name, i.Salary);

            }

            //FindIndex() function
            int index = customersList.FindIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Index using Findindex funtion is: {0}", index);

            //FindLastIndex() function
            int index1 = customersList.FindLastIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Index using FindLastIndex funtion is: {0}", index1);

            //Convert array to List
            ClsCustomer[] customersArray = new ClsCustomer[3];
            customersArray[0] = cust1;
            customersArray[1] = cust2;
            customersArray[2] = cust3;

            List<ClsCustomer> arrayToList = customersArray.ToList();
            foreach (ClsCustomer i in arrayToList)
            {
                Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", i.Id, i.Name, i.Salary);

            }

            //Convert list to array
            List<ClsCustomer> ListToArrayCustomers = new List<ClsCustomer>(2);
            ListToArrayCustomers.Add(cust1);
            ListToArrayCustomers.Add(cust2);
            ListToArrayCustomers.Add(cust3);
            ListToArrayCustomers.ToArray();
            foreach (ClsCustomer i in ListToArrayCustomers)
            {
                Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", i.Id, i.Name, i.Salary);

            }

            //Convert List to Dictionary
            List<ClsCustomer> ListToDictCustomers = new List<ClsCustomer>(2);
            ListToDictCustomers.Add(cust1);
            ListToDictCustomers.Add(cust2);
            ListToDictCustomers.Add(cust3);
            Dictionary<int, ClsCustomer> dict = ListToDictCustomers.ToDictionary(x => x.Id);

            foreach (KeyValuePair<int,ClsCustomer> kvp in dict)
            {
                Console.WriteLine("Key={0}", kvp.Key);
                ClsCustomer customervalue = kvp.Value;
                Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", customervalue.Id, customervalue.Name, customervalue.Salary);
            }


        }

    }
}