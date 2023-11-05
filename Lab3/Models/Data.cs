using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string name { get; set; }
        [MinLength(2, ErrorMessage = "Imię musi składać się z minimum 2 znaków."), MaxLength(50)]

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        public string surname { get; set; }
        [MinLength(2), MaxLength(50)]

        [Required(ErrorMessage = "Proszę podać hasło.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$", ErrorMessage = "Hasło musi zawierać minimum 8 znaków, co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        public string password { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło.")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasło i Potwierdź Hasło muszą być takie same.")]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string email { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Proszę podać poprawny numer telefonu.")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "Prosze podaj Wiek")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80.")]
        public int age { get; set; }

        [Required(ErrorMessage = "Prosze podaj Miasto")]
        public string city { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string topic { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string description { get; set; }
    }
}
