using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia.Intranet.Models.CMS
{
    public class Aktualnosc
    {
        [Key]
        public int IdAktualnosci { get; set; }
        
        [Required(ErrorMessage = "Wpisz tytuł odnośnika do aktualnosci")]
        [MaxLength(ErrorMessage = "Tytuł powinien zawierać max 10 znaków")]
        [Display(Name = "Tytół odnośnika aktualnosci")]
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł aktualności")]
        [MaxLength(ErrorMessage = "Tytuł aktualności powinien zawierać max 30 znaków")]
        [Display(Name = "Tytół aktualności")]
        public string Tytul { get; set; }

        [Display(Name = "Treść aktualnośći")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Display(Name = "Pozycja wyświetlania aktualnośći")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Pozycja { get; set; }

    }
}
