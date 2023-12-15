using System.ComponentModel.DataAnnotations;

namespace EasyTours.Models.ViewModels
{
    public class AddTourViewModel
    {
        [Required(ErrorMessage = "Введите название")]
        public string HotelName { get; set; }

        [Required(ErrorMessage = "Введите дату начала тура")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Введите последний день тура")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Введите дату и время вылета (отправление)")]
        public DateTime DepartureStartTime { get; set; }

        [Required(ErrorMessage = "Введите дату и время прилета (отправление)")]
        public DateTime DepartureEndTime { get; set; }

        [Required(ErrorMessage = "Введите дату и время вылета (обратно)")]
        public DateTime ArrivalStartTime { get; set; }

        [Required(ErrorMessage = "Введите дату и время прилета (обратно)")]
        public DateTime ArrivalEndTime { get; set; }

        [Required(ErrorMessage = "Укажите цену")]
        public decimal Price { get; set; }

        public decimal? Discount { get; set; }

        [Required(ErrorMessage = "Введите точку отправления")]
        public string DeparturePoint { get; set; }

        [Required(ErrorMessage = "Введите страну прибытия")]
        public string ArrivalCountry { get; set; }

        [Required(ErrorMessage = "Введите точку прибытия")]
        public string ArrivalPoint { get; set; }

        [Required(ErrorMessage = "Введите описание")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Введите количество туров")]
        public int Count { get; set; }
    }
}
