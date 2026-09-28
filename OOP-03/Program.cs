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
            #region Part 01 — Theoretical Questions Q2
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //*To prevent inheritance so that no other class can inherit/derive from it.
            //b)  What is the difference between a sealed class and a sealed method?
            //*Sealed Class: Prevents the entire class from being inherited.
            //*Sealed Method: Prevents a specific overridden method from being overridden again in further derived classes.
            //c)  Can a sealed method be overridden? Why?
            //*No. Because the primary purpose of the ⁠sealed⁠ keyword on a method is to explicitly block and prevent further overriding in child classes.

            #endregion
            #region Part 02 — Practical

            //a.Create a Driver
            // a. Create a Driver
            Driveer driver = new Driveer("D-101", "Ahmed Ali", "01012345678");

            // b. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter( "Cairo Main Hub");

            // c. Assign the Driver to the DeliveryCenter
            center.AssignedDriver = driver;

            // d. Create one StandardShipment
            DeliveryAddress addr1 = new DeliveryAddress();
            StandardShipment stdShipment = new StandardShipment("SH-001", "Electronics", 2.5, 50m, addr1);

            // e. Create one ExpressShipment
            DeliveryAddress addr2 = new DeliveryAddress();
            ExpressShipment expShipment = new ExpressShipment("SH-002", "Documents", 1.0, 30m, addr2);

            // f. Create one InternationalShipment
            DeliveryAddress addr3 = new DeliveryAddress();
            InternationalShipment intShipment = new InternationalShipment("SH-003", "Gift Box", 5.0, 100m, addr3);

            // g. Add all shipments to the DeliveryCenter
            center.AddShipment(stdShipment);
            center.AddShipment(expShipment);
            center.AddShipment(intShipment);

            // h. Print all shipments using PrintAllShipments()
            Console.WriteLine("=== Testing PrintAllShipments ===");
            center.PrintAllShipments();

            // i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
            Console.WriteLine("\n=== Testing DeliveryHelper ===");
            DeliveryHelper.PrintShipmentDetails(stdShipment);
            Console.WriteLine("----------------------------------");
            DeliveryHelper.PrintShipmentDetails(expShipment);
            Console.WriteLine("----------------------------------");
            DeliveryHelper.PrintShipmentDetails(intShipment);

            // j. Demonstrate both versions of UpdateWeight()
            Console.WriteLine("\n=== Testing UpdateWeight Overloads ===");
            stdShipment.UpdateWeight(3.0); // Version 1: double (kg)
            stdShipment.UpdateWeight(500); // Version 2: int (grams)

            // k. Build a Shipment[] holding mixed types and print all of them in a loop
            Console.WriteLine("\n=== Testing Polymorphic Array Loop ===");
            Shipment[] mixedShipments = new Shipment[]
            {
              stdShipment,
              expShipment,
              intShipment
            };

            foreach (Shipment s in mixedShipments)
            {
                s.PrintShipment();
                Console.WriteLine("----------------------------------");
            }
            #endregion

        }
    }
}
