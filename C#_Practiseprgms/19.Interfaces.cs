namespace MyPractise
{
    public class ClsInterfaces
    {
        public interface IPrintable
        {
            void Print();
        }

        public interface IShowable
        {
            void Show();
        }
        // Implementing multiple interfaces
        public class Document : IPrintable, IShowable
        {
            public void Print()
            {
                Console.WriteLine("Print method from IPrintable interface.");
            }

            public void Show()
            {
                Console.WriteLine("Show method from IShowable interface.");
            }
        }

        public interface ICustomer1
        {
            void Print1();
        }
        // Inheriting from another interface
        public interface ICustomer2 : ICustomer1
        {
            void Print2();
        }
        // Implementing the derived interface
        public class Customer : ICustomer2
        {
            public void Print1()
            {
                Console.WriteLine("Print1 method from ICustomer1 interface.");
            }

            public void Print2()
            {
                Console.WriteLine("Print2 method from ICustomer2 interface.");
            }
        }


        public static void InterfacesExample()
        {
            Document doc = new Document();
            doc.Print();
            doc.Show();
            Customer cust = new Customer();
            cust.Print1();
            cust.Print2();
        }

        // Note: Interfaces cannot contain fields, constructors, destructors, or static members.
        // They can contain properties, methods, events, and indexers.

        //Explicit Interface Implementation
        public interface IFirst
        {
            void Display();
        }
        public interface ISecond
        {
            void Display();
        }
        public class ExplicitExample : IFirst, ISecond
        {
            // Explicit interface implementation
            void IFirst.Display()
            {
                Console.WriteLine("Display method from IFirst interface.");
            }

            void ISecond.Display()
            {
                Console.WriteLine("Display method from ISecond interface.");
            }
        }
        public static void ExplicitInterfaceExample()
        {
            ExplicitExample example = new ExplicitExample();
            // The following line would cause a compile-time error
            // example.Display(); // ❌ Error: Print is not accessible directly


            // Calling the Display method from IFirst interface
            IFirst first = example;
            first.Display();

            // Calling the Display method from ISecond interface
            ISecond second = example;
            second.Display();
        }
    }
}