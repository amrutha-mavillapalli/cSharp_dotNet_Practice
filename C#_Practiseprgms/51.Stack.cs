namespace MyPractise
{
    public class ClsStack
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
        public static void StackExample()
        {
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Gender = "Male" };
            ClsCustomer cust2 = new ClsCustomer() { Id = 2, Name = "Bob", Gender = "Male" };
            ClsCustomer cust3 = new ClsCustomer() { Id = 3, Name = "Charlie", Gender = "Male" };
            ClsCustomer cust4 = new ClsCustomer() { Id = 4, Name = "Pam", Gender = "Female" };
            ClsCustomer cust5 = new ClsCustomer() { Id = 5, Name = "Valarie", Gender = "Female" };
            Stack<ClsCustomer> stackCustomers = new Stack<ClsCustomer>();
            stackCustomers.Push(cust1);
            stackCustomers.Push(cust2);
            stackCustomers.Push(cust3);
            stackCustomers.Push(cust4);
            stackCustomers.Push(cust5);
            Console.WriteLine("Elements in the stack:");
            foreach (ClsCustomer item in stackCustomers)
            {
                Console.WriteLine("Customer details: ID={0}, Name={1}", item.Id, item.Name);
                Console.WriteLine("Items left in the stack: {0}", stackCustomers.Count);
            }
            // pop method removes and returns the object at the top of the Stack
            ClsCustomer c1 = stackCustomers.Pop();
            Console.WriteLine("Popped customer details: ID={0}, Name={1}", c1.Id, c1.Name);
            Console.WriteLine("Total elements in the stack after Pop: {0}", stackCustomers.Count);
            // peek method returns the object at the top of the Stack without removing it.
            ClsCustomer c2 = stackCustomers.Peek();
            Console.WriteLine("Peeked customer details: ID={0}, Name={1}", c2.Id, c2.Name);
            Console.WriteLine("Total elements in the stack after Peek: {0}", stackCustomers.Count);
            // contains() method will check whether the specific element is present in the stack or not
            if (stackCustomers.Contains(cust3))
            {
                Console.WriteLine("cust3 is present in the stack");
            }
            else
            {
                Console.WriteLine("cust3 is not present in the stack");
            }
            // clear() method removes all the elements from the stack
            stackCustomers.Clear();
            Console.WriteLine("Total elements in the stack after Clear: {0}", stackCustomers.Count);
            

        }
    } }
