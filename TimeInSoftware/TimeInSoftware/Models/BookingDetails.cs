namespace TimeInSoftware.Models
{
    public class BookingDetails
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepartureTimeUTC { get; set; }
        //public DateTime DepartureTimeLocal { get; set; }
        //public string TimeZoneID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
