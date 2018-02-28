using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Polymorphism
    {

    }
    /// <summary>
    /// polymorphism allows you to invoke derived class method through reference of base class.
    /// for ex: if you create a object for derived class of type base class, then base class method is invoked at runtime.
    /// if you create a object for derived class of type derived class, then derived class method is invoked at runtime.
    /// but if you want to create obhect for derived class of type base class and invoke derived class method 
    /// then we can do it by polymorphism,
    /// The base class method is declared virtual and derived class method is declared override.
    /// Then create a object for derived class of type base class and call the method (invokes derived class method)
    /// </summary>
    class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName+" - "+LastName);
        }
    }
    class PartTimeEmployee : Employee
    {
        public override  void PrintFullName()
        {
            Console.WriteLine(FirstName + " - " + LastName+" - "+"Partime");
        }
    }
    class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " - " + LastName + " - " + "FullTime");
        }
    }
    class TemporaryEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " - " + LastName + " - " + "Temporary");
        }
    }
}
