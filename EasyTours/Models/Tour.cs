namespace EasyTours.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        //короткие даты относятся к туру
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //даты относящиеся к преодолению пути
        public DateTime DepartureStartTime { get; set; }
        public DateTime DepartureEndTime { get; set; }
        public DateTime ArrivalStartTime { get; set; }
        public DateTime ArrivalEndTime { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalCountry { get; set; }
        public string ArrivalPoint { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
