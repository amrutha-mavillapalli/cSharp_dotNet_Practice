namespace MyPractise
{
    public class ClsDictionary
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            
        }

        public static void DictionaryExample()
        {
            // Create customer objects
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Salary = 50000 };
            ClsCustomer cust2 = new ClsCustomer() { Id = 2, Name = "Bob", Salary = 60000 };
            ClsCustomer cust3 = new ClsCustomer() { Id = 3, Name = "Charlie", Salary = 70000 };

            // Create a dictionary to hold int keys and customer object values
            Dictionary<int, ClsCustomer> CustomersDict = new Dictionary<int, ClsCustomer>();

            // Adding customer objects to the dictionary
            CustomersDict.Add(cust1.Id, cust1);
            CustomersDict.Add(cust2.Id, cust2);
            CustomersDict.Add(cust3.Id, cust3);

            ClsCustomer customer3 = CustomersDict[3];
            Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", customer3.Id, customer3.Name, customer3.Salary);
            // Iterating through the dictionary
            foreach (var kvp in CustomersDict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                ClsCustomer cust = kvp.Value;
                Console.WriteLine("Customer ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
                Console.WriteLine("-------------------");
            }
            //Iterating through the dictionary keys
            Console.WriteLine("Iterating through the dictionary keys:");
            foreach (int key in CustomersDict.Keys)
            {
                Console.WriteLine("Key = {0}", key);
            }
            //Iterating through the dictionary values
            Console.WriteLine("Iterating through the dictionary values:");
            foreach (ClsCustomer cust in CustomersDict.Values)
            {
                Console.WriteLine("Customer ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }
            // Handling exceptions when adding duplicate keys
            // if we want to check if a customer exists before adding it to the dictionary to avoid exception
            if (!CustomersDict.ContainsKey(3))
            {
                CustomersDict.Add(cust3.Id, cust3);
            }
            else
            {
                Console.WriteLine("Customer with ID 3 already exists in the dictionary.");
            }

            // if we want to check if a key exists before accessing it
            if (CustomersDict.ContainsKey(5))
            {
                ClsCustomer customer5 = CustomersDict[5];
                Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", customer5.Id, customer5.Name, customer5.Salary);
            }
            else
            {
                Console.WriteLine("Customer with ID 5 does not exist in the dictionary.");
            }

            // Using TryGetValue methid to safely access a value
            if (CustomersDict.TryGetValue(2, out ClsCustomer customer2))
            {
                Console.WriteLine("Customer with ID = {0}, Name = {1}, Salary = {2}", customer2.Id, customer2.Name, customer2.Salary);
            }
            else
            {
                Console.WriteLine("Customer with ID 2 does not exist in the dictionary.");
            }
            //Counting elements in the dictionary
            Console.WriteLine("Total number of customers in the dictionary: " + CustomersDict.Count);
            // Count using LINQ
            Console.WriteLine("Total number of customers in the dictionary using LINQ: " + CustomersDict.Count(kvp => kvp.Value.Salary > 55000));

            // Removing an element from the dictionary
            CustomersDict.Remove(1);
            Console.WriteLine("Total number of customers in the dictionary after removing customer with ID 1: " + CustomersDict.Count);
            // Clearing the dictionary
            CustomersDict.Clear();
            Console.WriteLine("Total number of customers in the dictionary after clearing: " + CustomersDict.Count);

            // differnt ways to convert an array to a dictionary
            ClsCustomer[] customersArray = new ClsCustomer[3];
            customersArray[0] = cust1;
            customersArray[1] = cust2;
            customersArray[2] = cust3;
            
            // Using ToDictionary method from LINQ
            Dictionary<int, ClsCustomer> customersDictFromArray = customersArray.ToDictionary(c => c.Id);
            Console.WriteLine("Total number of customers in the dictionary created from array: " + customersDictFromArray.Count);
            // Using a loop to add elements to the dictionary
            Dictionary<int, ClsCustomer> customersDictFromArray2 = new Dictionary<int, ClsCustomer>();
            foreach (ClsCustomer cust in customersArray)
            {
                customersDictFromArray2.Add(cust.Id, cust);
            }

            //differnt ways to convert a list to a dictionary
            List<ClsCustomer> customersList = new List<ClsCustomer>();
            customersList.Add(cust1);
            customersList.Add(cust2);
            customersList.Add(cust3);
            // Using ToDictionary method from LINQ
            Dictionary<int, ClsCustomer> customersDictFromList = customersList.ToDictionary(c => c.Id);
            Console.WriteLine("Total number of customers in the dictionary created from list: " + customersDictFromList.Count);
            // Using a loop to add elements to the dictionary
            Dictionary<int, ClsCustomer> customersDictFromList2 = new Dictionary<int, ClsCustomer>();
            foreach (ClsCustomer cust in customersList)
            {
                customersDictFromList2.Add(cust.Id, cust);
            }

        }
    }
}