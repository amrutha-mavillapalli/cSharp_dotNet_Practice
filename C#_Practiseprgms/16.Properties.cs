namespace MyPractise
{
    public class ClsProperties
    {
        private int _id; // field
        private string _name;  // field
        private int _passmark = 35; // field

        // auto-implemented property
        public string email { get; set; }

        public int Passmark
        {
            get
            {
                return this._passmark;
            }

        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty.");
                }
                this._name = value;
            }
            get { return string.IsNullOrEmpty(this._name) ? "No name set" : this._name; }

        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id must be positive.");
                }
                _id = value;
            }
            get { return _id; }
        }
        // Property for firstName
        // public string FirstName
        // {
        //     get { return firstName; }
        //     set { firstName = value; }
        // }


        public static void PropertiesExample()
        {
            ClsProperties C1 = new ClsProperties();
            C1.Id = 101; // Using property to set Id 
            C1.Name = "Amrutha"; // Using property to set Name
            // C1.Passmark = 65; // This will give error as Passmark is read-only property


            Console.WriteLine("Student Id: " + C1.Id); // Using getter
            Console.WriteLine("Student Name: " + C1.Name);   // Using getter
            Console.WriteLine("Student Passmarks: " + C1.Passmark);   // Using read-only property
        }
    }
}