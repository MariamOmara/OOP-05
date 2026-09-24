
////Q2 PR
//public class DeliveryAddress
//{
//    public string City { get; set; }
//    public string Street { get; set; }
//}

//public class Shipment
//{
//    public int Id { get; set; }

//    public DeliveryAddress DeliveryAddress { get; set; }

//    // Q1 - Object Copying
//    public Shipment CopyShipment()
//    {
//        return new Shipment
//        {
//            Id = this.Id,
//            DeliveryAddress = this.DeliveryAddress
//        };
//    }

//    // Q2 - Shallow Copy
//    public Shipment ShallowCopy()
//    {
//        return (Shipment)this.MemberwiseClone();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Shipment shipment1 = new Shipment
//        {
//            Id = 1,
//            DeliveryAddress = new DeliveryAddress
//            {
//                City = "Cairo",
//                Street = "Main Street"
//            }
//        };

//        // Q1 - Assigning reference
//        Shipment shipment2 = shipment1;

//        // Q1 - Creating actual copy
//        Shipment shipment3 = shipment1.CopyShipment();

//        Console.WriteLine("Q1 - Object Copying");
//        Console.WriteLine(shipment1 == shipment2); // True
//        Console.WriteLine(shipment1 == shipment3); // False


//        // Q2 - Shallow Copy
//        Shipment shallowCopy = shipment1.ShallowCopy();

//        Console.WriteLine("\nQ2 - Shallow Copy");

//        // Different Shipment objects
//        Console.WriteLine(shipment1 == shallowCopy); // False

//        // Same DeliveryAddress object
//        Console.WriteLine(
//            shipment1.DeliveryAddress == shallowCopy.DeliveryAddress
//        ); // True

//        // Change address through copied Shipment
//        shallowCopy.DeliveryAddress.City = "Alexandria";

//        Console.WriteLine(
//            "Original City: " + shipment1.DeliveryAddress.City
//        );

//        Console.WriteLine(
//            "Copied City: " + shallowCopy.DeliveryAddress.City
//        );
//    }
//}










//Q3 PR

//using System;

//public class DeliveryAddress
//{
//    public string City { get; set; }
//    public string Street { get; set; }
//}

//public class Shipment
//{
//    public int Id { get; set; }

//    public DeliveryAddress DeliveryAddress { get; set; }

//    // Q1 - Object Copying
//    public Shipment CopyShipment()
//    {
//        return new Shipment
//        {
//            Id = this.Id,
//            DeliveryAddress = this.DeliveryAddress
//        };
//    }

//    // Q2 - Shallow Copy
//    public Shipment ShallowCopy()
//    {
//        return (Shipment)this.MemberwiseClone();
//    }

//    // Q3 - Deep Copy
//    public Shipment DeepCopy()
//    {
//        return new Shipment
//        {
//            Id = this.Id,

//            // Create a new DeliveryAddress
//            DeliveryAddress = new DeliveryAddress
//            {
//                City = this.DeliveryAddress.City,
//                Street = this.DeliveryAddress.Street
//            }
//        };
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Shipment shipment1 = new Shipment
//        {
//            Id = 1,
//            DeliveryAddress = new DeliveryAddress
//            {
//                City = "Cairo",
//                Street = "Main Street"
//            }
//        };

//        // =========================
//        // Q1 - Object Copying
//        // =========================

//        Shipment shipment2 = shipment1;

//        Shipment shipment3 = shipment1.CopyShipment();

//        Console.WriteLine("Q1 - Object Copying");
//        Console.WriteLine(shipment1 == shipment2); // True
//        Console.WriteLine(shipment1 == shipment3); // False


//        // =========================
//        // Q2 - Shallow Copy
//        // =========================

//        Shipment shallowCopy = shipment1.ShallowCopy();

//        Console.WriteLine("\nQ2 - Shallow Copy");

//        // Different Shipment objects
//        Console.WriteLine(shipment1 == shallowCopy); // False

//        // Same DeliveryAddress object
//        Console.WriteLine(
//            shipment1.DeliveryAddress == shallowCopy.DeliveryAddress
//        ); // True

//        // Change address through copied Shipment
//        shallowCopy.DeliveryAddress.City = "Alexandria";

//        Console.WriteLine(
//            "Original City: " + shipment1.DeliveryAddress.City
//        );

//        Console.WriteLine(
//            "Copied City: " + shallowCopy.DeliveryAddress.City
//        );


//        // =========================
//        // Q3 - Deep Copy
//        // =========================

//        // Create a completely independent copy
//        Shipment deepCopy = shipment1.DeepCopy();

//        Console.WriteLine("\nQ3 - Deep Copy");

//        // Before changing copied address
//        Console.WriteLine(
//            "Original City: " + shipment1.DeliveryAddress.City
//        );

//        Console.WriteLine(
//            "Copied City: " + deepCopy.DeliveryAddress.City
//        );

//        // Change copied address
//        deepCopy.DeliveryAddress.City = "Giza";

//        // After changing copied address
//        Console.WriteLine("\nAfter changing copied address:");

//        Console.WriteLine(
//            "Original City: " + shipment1.DeliveryAddress.City
//        );

//        Console.WriteLine(
//            "Copied City: " + deepCopy.DeliveryAddress.City
//        );

//        // Check if both use the same DeliveryAddress object
//        Console.WriteLine(
//            "Same DeliveryAddress object? "
//            + (shipment1.DeliveryAddress == deepCopy.DeliveryAddress)
//        );
//    }
//}