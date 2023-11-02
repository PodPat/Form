using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; }


        [Required(ErrorMessage = "Prosze podaj nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj haslo")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Haslo {  get; set; }

        [Required(ErrorMessage = "Potwierdz haslo")]
        [Compare("Haslo", ErrorMessage = "Password and Confirm Password have to be the same")]
        public string Haslo_2 { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{9}", ErrorMessage = "Numer telefonu musi składać się z 9 cyfr.")]
        public string nr_telefonu { get; set; }

        [Range(10, 80)]
        public int Wiek {get; set;}

        [Required(ErrorMessage = "Prosze podaj email")]
        public string Email { get; set; }
        

        public string Miasto { get; set; }
        public enum Miasta { Krakow = 1, Warszawa = 2, Wroclaw = 3, Lodz = 4, Gdansk = 5 }


    }
}
