namespace MyPractise
{
    public class ClsOverrideEqualsMethod
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Override Equals method
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Person other = (Person)obj;
                return this.FirstName == other.FirstName && this.LastName == other.LastName;
            }

            // It's a good practice to override GetHashCode when Equals is overridden
            public override int GetHashCode()
            {
                return (FirstName + LastName).GetHashCode();
            }
        }

        public static void OverrideEqualsExample()
        {
            Person person1 = new Person { FirstName = "Amrutha", LastName = "Mavillapalli" };
            Person person2 = new Person { FirstName = "Amrutha", LastName = "Mavillapalli" };
            Person person3 = new Person { FirstName = "John", LastName = "Doe" };

            // Using overridden Equals method
            Console.WriteLine("person1 equals person2: " + person1.Equals(person2)); // True
            Console.WriteLine("person1 equals person3: " + person1.Equals(person3)); // False

            // Without overriding Equals method, it would compare references and return false
            object obj1 = new object();
            object obj2 = new object();
            Console.WriteLine("obj1 equals obj2: " + obj1.Equals(obj2)); // False
        }
    }
}