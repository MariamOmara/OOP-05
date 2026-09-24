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










using System;

class Program
{
    static void Main(string[] args)
    {
        Shipment shipment = new Shipment();

        shipment.TrackingStatus = "In Transit";

        shipment.UpdateTrackingStatus("Out For Delivery");
    }
}