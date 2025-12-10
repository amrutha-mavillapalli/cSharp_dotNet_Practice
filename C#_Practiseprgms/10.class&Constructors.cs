using System;
namespace MyPractise;

public class ClsCustomer
{
    string _firstName;
    string _lastName;

   //constructors: with same name as class name and no return type.
   //1. Default constructor: no parameters
   //2. Parameterized constructor: with parameters
   //3. Constructor Overloading: multiple constructors with different parameters, eg as below with 2 constructors
   //4. Constructor Chaining: calling one constructor from another using 'this' keyword
   //5. Static constructor: to initialize static members of the class, called once when the class is loaded.
    public ClsCustomer() : this("No First Name provided", "No Last Name provided")
    {
    }
    public ClsCustomer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Customer Full Name: {0} {1}", _firstName, _lastName);
    }

    ~ClsCustomer()
    {
        // Destructor logic if needed, not commonly used in C# because of garbage collection.
    }


}
