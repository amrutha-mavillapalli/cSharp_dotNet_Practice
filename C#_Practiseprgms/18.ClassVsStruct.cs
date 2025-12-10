namespace MyPractise
{
    public class ClsClassVsStruct
    {
        public class PersonClass
        {
            public int Id;
            public string Name;

            public PersonClass(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        public struct PersonStruct
        {
            public int Id;
            public string Name;

            public PersonStruct(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        public static void ClassVsStructExample()
        {
            // Class example. // Reference type
            PersonClass person1 = new PersonClass(1, "Alice");
            PersonClass person2 = person1; // person2 references the same object as person1
            person2.Name = "Bob";

            Console.WriteLine("Class - Reference type:");
            Console.WriteLine("person1 Name: " + person1.Name); // Outputs "Bob"
            Console.WriteLine("person2 Name: " + person2.Name); // Outputs "Bob"

            // Struct example // Value type
            PersonStruct struct1 = new PersonStruct(1, "Charlie");
            PersonStruct struct2 = struct1; // struct2 is a copy of struct1
            struct2.Name = "David";

            Console.WriteLine("\nStruct - Value Type:");
            Console.WriteLine("struct1 Name: " + struct1.Name); // Outputs "Charlie"
            Console.WriteLine("struct2 Name: " + struct2.Name); // Outputs "David"
        }
    }
}