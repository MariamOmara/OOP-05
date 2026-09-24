public partial class Shipment
{
    // Q8 / Q9 - Tracking Status

    public string TrackingStatus { get; set; }

    public string GetTrackingStatus()
    {
        return TrackingStatus;
    }

    public void UpdateTrackingStatus(string newStatus)
    {
        TrackingStatus = newStatus;
    }
}