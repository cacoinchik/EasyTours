namespace EasyTours.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public byte Age { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int? TourId { get; set; }
        public virtual Tour? Tour { get; set; }
    }
}
