using System.Numerics;
using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions Q1
            //a)  What is the difference between Method Overloading and Method Overriding?
            //Method Overloading: Same method name with different parameters within the same class (Resolved at Compile-time).
            // Method Overriding: Redefining a base class method in a derived class using ⁠virtual⁠ and ⁠override⁠(Resolved at Runtime).

            //b)  What is the difference between Static Binding and Dynamic Binding?
            //Static Binding (Early Binding): The method call is linked at compile-time based on the reference type (Faster, used in non-virtual and overloaded methods).
           // Dynamic Binding(Late Binding): The method call is linked at runtime based on the actual object type(Used in virtual/overridden methods for polymorphism).
            #endregion
        }
    }
}
