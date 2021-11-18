using System.ComponentModel.DataAnnotations;

namespace Lab3_test4.Models
{
    public class ZadanieModel
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Ilość powtórzen")]
        [Required]
        public int Ilosc_Powtorzen { get; set; }

    }
}
