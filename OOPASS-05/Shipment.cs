



////Q9

//using System;

//public partial class Shipment
//{
//    // Main Properties
//    public int Id { get; set; }

//    public DeliveryAddress DeliveryAddress { get; set; }

//    public string TrackingCode { get; set; }

//    public string ShipmentType { get; set; }

//    public double Weight { get; set; }

//    public double EstimatedCost { get; set; }

//    // Q4 - Static Field
//    public static int TotalShipmentsCreated = 0;

//    // Q5 - Static Constructor
//    static Shipment()
//    {
//        TotalShipmentsCreated = 0;
//        Console.WriteLine("Shipment System Initialized");
//    }

//    // Normal Constructor
//    public Shipment()
//    {
//        TotalShipmentsCreated++;
//    }

//    // Q6 - Static Method
//    public static int GetTotalShipmentsCreated()
//    {
//        return TotalShipmentsCreated;
//    }

//    // Q1 - Object Copying
//    public Shipment CopyShipment()
//    {
//        return new Shipment
//        {
//            Id = this.Id,
//            DeliveryAddress = this.DeliveryAddress,
//            TrackingCode = this.TrackingCode,
//            ShipmentType = this.ShipmentType,
//            Weight = this.Weight,
//            EstimatedCost = this.EstimatedCost,
//            TrackingStatus = this.TrackingStatus
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

//            DeliveryAddress = new DeliveryAddress
//            {
//                City = this.DeliveryAddress.City,
//                Street = this.DeliveryAddress.Street
//            },

//            TrackingCode = this.TrackingCode,
//            ShipmentType = this.ShipmentType,
//            Weight = this.Weight,
//            EstimatedCost = this.EstimatedCost,
//            TrackingStatus = this.TrackingStatus
//        };
//    }

//    // Print Shipment
//    public void PrintShipment()
//    {
//        Console.WriteLine("Shipment ID: " + Id);
//        Console.WriteLine("Tracking Code: " + TrackingCode);
//        Console.WriteLine("Shipment Type: " + ShipmentType);
//        Console.WriteLine("Weight: " + Weight + " KG");
//        Console.WriteLine("Estimated Cost: " + EstimatedCost);
//        Console.WriteLine("Tracking Status: " + TrackingStatus);
//    }
//}



//Q10

//using System;

//public partial class Shipment
//{
//    public int Id { get; set; }

//    public string TrackingStatus { get; set; }

//    // Declare Partial Method
//    partial void OnTrackingStatusChanged(string newStatus);

//    public void UpdateTrackingStatus(string newStatus)
//    {
//        TrackingStatus = newStatus;

//        // Call Partial Method
//        OnTrackingStatusChanged(newStatus);
//    }
//}