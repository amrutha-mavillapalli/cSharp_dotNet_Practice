namespace MyPractise
{
    public class ClsInheritance
    {
        // Base class
        public class Employee
        {
            public string firstName;
            public string lastName;

            public void PrintFullName()
            {
                Console.WriteLine("Employee Full Name: {0} {1}", firstName, lastName);
            }

        }
        public class FullTimeEmployee : Employee
        {
           // decimal annualSalary;

        }
        public class PartTimeEmployee : Employee
        {
            //decimal hourlyPay;
        }
        public static void Inheritance()
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.firstName = "Amrutha";
            fte.lastName = "Mavillapalli";
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstName = "John";
            pte.lastName = "Cena";
            pte.PrintFullName();

            Console.WriteLine();
            Console.WriteLine("Multi-level Inheritance Example:");
            C objC = new C();
            objC.printA();
            objC.printB();
            objC.printC();
            Console.WriteLine();

            Console.WriteLine("Hierarchical Inheritance Example:");
            Child1 child1 = new Child1();
            child1.showParent();
            child1.showChild1();
            Child2 child2 = new Child2();
            child2.showParent();
            child2.showChild2();

            Console.WriteLine();
            Console.WriteLine("Constructor Inheritance Example:");
            ChildWithConstructor childWithConstructor = new ChildWithConstructor();
            Console.WriteLine();
        
        }

        //example of multi-level inheritance
        public class A
        {
            public void printA()
            {
                Console.WriteLine("Class A method");
            }
        }
        public class B : A
        {
            public void printB()
            {
                Console.WriteLine("Class B method");
            }
        }
        public class C : B
        {
            public void printC()
            {
                Console.WriteLine("Class C method");
            }
        }
        //example of hierarchical inheritance
        // multiple child classes inherit from a single parent (base) class.
        public class Parent
        {
            public void showParent()
            {
                Console.WriteLine("Parent class method");
            }
        }
        public class Child1 : Parent
        {
            public void showChild1()
            {
                Console.WriteLine("Child1 class method");
            }
        }
        public class Child2 : Parent
        {
            public void showChild2()
            {
                Console.WriteLine("Child2 class method");
            }
        }

        // example of Parent class constructor executes before child class constructor.
        public class ParentWithConstructor
        {
            public ParentWithConstructor()
            {
                Console.WriteLine("Parent class constructor called");
            }
            public ParentWithConstructor(string msg)
            {
                Console.WriteLine("Parent class parameterized constructor called with message: " + msg);
            }
        }
        public class ChildWithConstructor : ParentWithConstructor
        {
            public ChildWithConstructor() : base("Hello from Child") // calling parent parameterized constructor using base keyword. 
            // this is optional here. and if not used, the default parent constructor is called automatically.
            {
                Console.WriteLine("Child class constructor called");
            }
        }
    }
}