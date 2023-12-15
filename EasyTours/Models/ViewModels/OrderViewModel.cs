using System.ComponentModel.DataAnnotations;

namespace EasyTours.Models.ViewModels
{
    public class OrderViewModel
    {
        public int TourId { get; set; }

        public decimal Price { get; set; }

        [Required(ErrorMessage ="Введите фамилию")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Введите возраст")]
        public byte Age { get; set; }

        [Required(ErrorMessage ="Укажите количество путевок")]
        public int Count { get; set; }

        //скидка 10%
        public bool IsAddDiscount { get; set; } = false;
        //скидка молодоженам
        public bool IsNewlyweds { get; set; } = false;
    }
}
