namespace MyPractise
{
    public class ClsAccessModifiers
    {
        public class ClsCustomer
        {
            private int id; // Private field
            public int ID
            {
                get { return id; } // Public property to access private field
                set { id = value; }
            }
            protected string name; // Protected field
        }
        public class ClsEmployee : ClsCustomer
        {
            public void SetName(string empName)
            {
                name = empName; // Accessing protected field from base class
            }
        }


        // Access Modifiers: public, private, protected, internal, protected internal, private protected

            // Public: Accessible from anywhere
            public string publicField = "I am a public field";

        // Private: Accessible only within the class
        private string privateField = "I am a private field";

        // Protected: Accessible within the class and by derived class instances
        protected string protectedField = "I am a protected field";

        // Internal: Accessible only within files in the same assembly
        internal string internalField = "I am an internal field";

        // Protected Internal: Accessible within the same assembly or from derived classes
        protected internal string protectedInternalField = "I am a protected internal field";

        // Private Protected: Accessible within the containing class or types derived from the containing class within the same assembly
        private protected string privateProtectedField = "I am a private protected field";

        public void DisplayFields()
        {
            ClsCustomer customer = new ClsCustomer();
            customer.ID = 123; // Accessing private field via public property
            Console.WriteLine(publicField);
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
            Console.WriteLine(internalField);
            Console.WriteLine(protectedInternalField);
            Console.WriteLine(privateProtectedField);
        }
    }   
}