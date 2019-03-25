using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TurniejMaxow.Models
{
    public class FormResponse
    {
        public enum Exercises
        {
            BenchPress
        }
        public int FormResponseID { get; set; }
        [Required(ErrorMessage = "Podaj swoje imie.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Podaj swoje nazwisko.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Proszę, podaj swój email.")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Proszę, podaj prawdziwy adres email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę, podaj swój numer telefonu.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Proszę, podaj swój wiek.")]
        [Range(18,100, ErrorMessage = "Nie masz odpowiedniego wieku.")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Proszę, podaj swój wzrost.")]
        [Range(130, 300, ErrorMessage = "Podaj prawdziwy wzrost!"
            )]
        public int? Height { get; set; }
        [Required(ErrorMessage = "Proszę, podaj swoją wagę.")]
        [Range(30, 300, ErrorMessage = "Podaj prawdziwą wagę."
            )]
        public int? Weight { get; set; }

        public DateTime Signed { get; set; }
        public int? CurrSquat { get; set; }
        public int? CurrDeadlift { get; set; }
        public int? CurrBench { get; set; }

        public int? CurrOhp { get; set; }
        public int? GoalSquat { get; set; }
        public int? GoalDeadlift { get; set; }
        public int? GoalBench { get; set; }
        public int? GoalOhp { get; set; }
    }
}
