//public partial class Shipment
//{
//    // Q8 / Q9 - Tracking Status

//    public string TrackingStatus { get; set; }

//    public string GetTrackingStatus()
//    {
//        return TrackingStatus;
//    }

//    public void UpdateTrackingStatus(string newStatus)
//    {
//        TrackingStatus = newStatus;
//    }
//}



using System;

public partial class Shipment
{
    public string TrackingStatus { get; set; }

    public string GetTrackingStatus()
    {
        return TrackingStatus;
    }

    public void UpdateTrackingStatus(string newStatus)
    {
        TrackingStatus = newStatus;

        OnTrackingStatusChanged(newStatus);
    }

    partial void OnTrackingStatusChanged(string newStatus)
    {
        Console.WriteLine(
            "Tracking status changed to: " + newStatus
        );
    }
}