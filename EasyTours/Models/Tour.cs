namespace EasyTours.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }
        public string? Description { get; set; }
    }
}
