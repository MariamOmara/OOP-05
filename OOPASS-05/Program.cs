// Q1 PRACT
// public class Shipment
//{
//    public int Id { get; set; }

//    public Shipment CopyShipment()
//    {
//        return new Shipment
//        {
//            Id = this.Id
//        };
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Shipment shipment1 = new Shipment();
//        shipment1.Id = 1;

// Assigning one object variable to another
// Both variables refer to the same object.
//Shipment shipment2 = shipment1;

// Creating an actual copy
// shipment3 is a new object.
//        Shipment shipment3 = shipment1.CopyShipment();

//        Console.WriteLine(shipment1 == shipment2);
//        Console.WriteLine(shipment1 == shipment3);
//    }
//}








//النظري

// Q1 Object Copying

// a) Assigning one object variable to another copies the reference.
// Both variables point to the same object.

// b) No, it does not create a new object.
// It only copies the reference.

// c) Copying a reference means both variables point to the same object.
// Copying an object means creating a new independent object.


// Q2 Shallow Copy vs Deep Copy

// a) Shallow Copy creates a new object, but reference-type members
// still point to the same objects.

// b) Deep Copy creates a completely independent copy of the object
// and its reference-type members.

// c) In a Shallow Copy, reference-type members share the same reference.

// d) In a Deep Copy, new objects are created for reference-type members.

// e) Deep Copy is safer when we need to modify the copied object
// without affecting the original object.


// Q3 Static Members

// a) A static field belongs to the class and is shared by all objects.
// An instance field belongs to each individual object.

// b) A static method belongs to the class.
// It cannot directly access instance members.

// c) A static constructor initializes static members.
// It executes once before the class is used.

// d) A static class contains only static members.
// You cannot create an object from a static class.


// Q4 Extension Methods

// a) An Extension Method adds functionality to an existing class
// without modifying the original class.

// b) The 'this' keyword must be used in the first parameter.

// c) An Extension Method must be declared inside a static class.

// d) No, an Extension Method cannot access private members
// of the class it extends.


// Q5 Partial Classes and Partial Methods

// a) A Partial Class allows one class to be divided into multiple files.

// b) Developers split a class into multiple files for better organization
// and easier code management.

// c) A Partial Method is a method declared in one part of a partial class
// and optionally implemented in another part.

// d) If a partial method has no implementation, it is removed during compilation










//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Shipment shipment = new Shipment();

//        shipment.TrackingStatus = "In Transit";

//        shipment.UpdateTrackingStatus("Out For Delivery");
//    }
//}







using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // System Title
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        DeliveryUtilities.PrintSystemTitle();

        DeliveryUtilities.PrintSeparator();


        // ==========================================
        // Static Constructor
        // ==========================================

        // Static constructor runs automatically
        // when Shipment is first used.


        // ==========================================
        // Creating Shipments
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Creating Shipments...");

        DeliveryUtilities.PrintSeparator();

        Shipment shipment1 = new Shipment
        {
            TrackingCode = "SH001",
            ShipmentType = "Standard",
            Weight = 3,
            TrackingStatus = "In Transit",

            DeliveryAddress = new DeliveryAddress
            {
                City = "Cairo",
                Street = "Main Street"
            }
        };

        Console.WriteLine("Standard Shipment Created");


        Shipment shipment2 = new Shipment
        {
            TrackingCode = "SH002",
            ShipmentType = "Express",
            Weight = 2,
            TrackingStatus = "Out For Delivery",

            DeliveryAddress = new DeliveryAddress
            {
                City = "Giza",
                Street = "Street 2"
            }
        };

        Console.WriteLine("Express Shipment Created");


        Shipment shipment3 = new Shipment
        {
            TrackingCode = "SH003",
            ShipmentType = "International",
            Weight = 8,
            TrackingStatus = "Delivered",

            DeliveryAddress = new DeliveryAddress
            {
                City = "Alexandria",
                Street = "Street 3"
            }
        };

        Console.WriteLine("International Shipment Created");


        Console.WriteLine();

        Console.WriteLine(
            "Total Shipments Created : "
            + Shipment.GetTotalShipmentsCreated()
        );


        // ==========================================
        // Object Copying
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Object Copying");

        DeliveryUtilities.PrintSeparator();

        Shipment assignedShipment = shipment1;

        Console.WriteLine(
            "Original Shipment  : " + shipment1.TrackingCode
        );

        Console.WriteLine(
            "Assigned Shipment  : " + assignedShipment.TrackingCode
        );

        Console.WriteLine();

        Console.WriteLine(
            "Same Object : "
            + (shipment1 == assignedShipment)
        );

        Console.WriteLine(
            "New Object Created : "
            + (shipment1 != assignedShipment)
        );


        // ==========================================
        // Shallow Copy
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Shallow Copy");

        DeliveryUtilities.PrintSeparator();

        Shipment shallowCopy = shipment1.ShallowCopy();

        Console.WriteLine(
            "Original Shipment Address : "
            + shipment1.DeliveryAddress.City
        );

        Console.WriteLine(
            "Copied Shipment Address   : "
            + shallowCopy.DeliveryAddress.City
        );

        Console.WriteLine();

        Console.WriteLine("Changing copied shipment address...");

        shallowCopy.DeliveryAddress.City = "Giza";

        Console.WriteLine();

        Console.WriteLine(
            "Original Shipment Address : "
            + shipment1.DeliveryAddress.City
        );

        Console.WriteLine(
            "Copied Shipment Address   : "
            + shallowCopy.DeliveryAddress.City
        );

        Console.WriteLine();

        Console.WriteLine(
            "Same DeliveryAddress Object : "
            + (
                shipment1.DeliveryAddress
                == shallowCopy.DeliveryAddress
            )
        );


        // ==========================================
        // Deep Copy
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Deep Copy");

        DeliveryUtilities.PrintSeparator();

        // Reset original address for demonstration
        shipment1.DeliveryAddress.City = "Cairo";

        Shipment deepCopy = shipment1.DeepCopy();

        Console.WriteLine(
            "Original Shipment Address : "
            + shipment1.DeliveryAddress.City
        );

        Console.WriteLine(
            "Copied Shipment Address   : "
            + deepCopy.DeliveryAddress.City
        );

        Console.WriteLine();

        Console.WriteLine("Changing copied shipment address...");

        deepCopy.DeliveryAddress.City = "Giza";

        Console.WriteLine();

        Console.WriteLine(
            "Original Shipment Address : "
            + shipment1.DeliveryAddress.City
        );

        Console.WriteLine(
            "Copied Shipment Address   : "
            + deepCopy.DeliveryAddress.City
        );

        Console.WriteLine();

        Console.WriteLine(
            "Same DeliveryAddress Object : "
            + (
                shipment1.DeliveryAddress
                == deepCopy.DeliveryAddress
            )
        );


        // ==========================================
        // Extension Methods
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Extension Methods");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine(
            shipment1.GetSummary()
        );

        Console.WriteLine(
            shipment2.GetSummary()
        );

        Console.WriteLine(
            shipment3.GetSummary()
        );

        Console.WriteLine();

        Console.WriteLine(
            "SH001 Is Delivered : "
            + shipment1.IsDelivered()
        );

        Console.WriteLine(
            "SH003 Is Delivered : "
            + shipment3.IsDelivered()
        );


        // ==========================================
        // Tracking Status
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Tracking Status");

        DeliveryUtilities.PrintSeparator();

        shipment1.UpdateTrackingStatus(
            "Out For Delivery"
        );


        // ==========================================
        // Static Utilities
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Static Utilities");

        DeliveryUtilities.PrintSeparator();

        DeliveryUtilities.PrintSystemTitle();

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine();

        Console.WriteLine(
            "Total Shipments Created : "
            + Shipment.GetTotalShipmentsCreated()
        );


        // ==========================================
        // Partial Method
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Partial Method");

        DeliveryUtilities.PrintSeparator();

        shipment3.UpdateTrackingStatus("Delivered");


        // ==========================================
        // Assignment Completed
        // ==========================================

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Assignment Completed");

        DeliveryUtilities.PrintSeparator();
    }
}