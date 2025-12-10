using System.Reflection;

namespace MyPractise
{
    public class ClsReflection
    {
         public int Id { get; set; }
            public string Name { get; set; }

            public ClsReflection(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public ClsReflection() { }   
            public void Display()
            {
                Console.WriteLine("Customer ID: " + Id + ", Name: " + Name);
            }
        public static void ReflectionExample()
        {

            // Get the type of the current class    
            // Type type = typeof(ClsReflection);
            Type T = Type.GetType("MyPractise.ClsReflection");
            Console.WriteLine("Fullname: " + T.FullName);
            Console.WriteLine("name: " + T.Name);
            Console.WriteLine("Namespace: " + T.Namespace);

            Console.WriteLine("Properties:");
            PropertyInfo[] properties = T.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(" - " + prop.Name);
            }

            Console.WriteLine("Methods:");
            MethodInfo[] methods = T.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(" - " + method.Name);
            }
            Console.WriteLine("Constructors:");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(" - " + constructor.ToString());
            }
        }
    }
}