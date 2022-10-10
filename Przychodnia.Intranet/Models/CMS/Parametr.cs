using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia.Intranet.Models.CMS
{
    public class Parametr
    {
        [Key]
        public int IdAktualnosci { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(10, ErrorMessage = "Kod powinien zawierać max 10 znaków")]
        public string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagany")]
        [MaxLength(50, ErrorMessage = "Nazwa powinien zawierać max 30 znaków")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Wartość jest wymagany")]
        [Display(Name ="Wartość")]
        public string Wartosc { get; set; }
        public string Opis { get; set; }

    }
}
