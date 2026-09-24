
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
