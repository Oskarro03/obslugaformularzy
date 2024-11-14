using System.ComponentModel.DataAnnotations;

namespace obslugaformularzy.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać Imię")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Nieprawidłowy adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać Temat")]
        public string Temat { get; set; }

        [Required(ErrorMessage = "Proszę podać treść wiadomości")]
        [MinLength(10, ErrorMessage = "Treść musi mieć co najmniej 10 znaków")]
        [MaxLength(50, ErrorMessage = "Treść nie może przekraczać 50 znaków")]
        public string Tresc { get; set; }
    }
}
