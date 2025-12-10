namespace MyPractise
{
    public class ClsQueue
    {
        public class ClsCustomer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
        public static void QueueExample()
        {
            ClsCustomer cust1 = new ClsCustomer() { Id = 1, Name = "Alice", Gender = "Male" };
            ClsCustomer cust2 = new ClsCustomer() { Id = 2, Name = "Bob", Gender = "Male" };
            ClsCustomer cust3 = new ClsCustomer() { Id = 3, Name = "Charlie", Gender = "Male" };
            ClsCustomer cust4 = new ClsCustomer() { Id = 4, Name = "Pam", Gender = "Female" };
            ClsCustomer cust5 = new ClsCustomer() { Id = 5, Name = "Valarie", Gender = "Female" };


            Queue<ClsCustomer> queueCustomers = new Queue<ClsCustomer>();
            queueCustomers.Enqueue(cust1);
            queueCustomers.Enqueue(cust2);
            queueCustomers.Enqueue(cust3);
            queueCustomers.Enqueue(cust4);
            queueCustomers.Enqueue(cust5);
            Console.WriteLine("Elements in the queue:");
            foreach (var item in queueCustomers)
            {
                Console.WriteLine("Customer details: ID={0}, Name={1}", item.Id, item.Name);
                Console.WriteLine("Items left in the queue: {0}", queueCustomers.Count);
            }

            // dequeue method removes and returns the object at the beginning of the Queue
            ClsCustomer c1 = queueCustomers.Dequeue();
            Console.WriteLine("Dequeued customer details: ID={0}, Name={1}", c1.Id, c1.Name);
            Console.WriteLine("Total elements in the queue after Dequeue: {0}", queueCustomers.Count);

            // peek method returns the object at the beginning of the Queue without removing it.
            ClsCustomer c2 = queueCustomers.Peek();
            Console.WriteLine("Peeked customer details: ID={0}, Name={1}", c2.Id, c2.Name);
            Console.WriteLine("Total elements in the queue after Peek: {0}", queueCustomers.Count);

            // contains() method will check whether the specific element is present in the queue or not
            if (queueCustomers.Contains(cust3))
            {
                Console.WriteLine("cust3 is present in the queue");
            }
            else
            {
                Console.WriteLine("cust3 is not present in the queue");
            }
            
            // clear() method removes all the elements from the queue
            queueCustomers.Clear();
            Console.WriteLine("Total elements in the queue after Clear: {0}", queueCustomers.Count);

        }
    }
}