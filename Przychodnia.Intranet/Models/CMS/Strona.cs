using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Przychodnia.Intranet.Models.CMS
{
    public class Strona
    {
        [Key]
        public int IdStrony {get; set;}
        
        [Required(ErrorMessage ="Wpisz tytuł odnośnika")]
        [MaxLength(10, ErrorMessage = "Tytuł powinien zawierać max 10 znaków")]
        [Display(Name = "Tytół odnośnika")]
        public string LinkTytul { get; set; }
        
        [Required(ErrorMessage = "Wpisz tytuł strony")]
        [MaxLength(50, ErrorMessage = "Tytuł strony powinien zawierać max 30 znaków")]
        [Display(Name = "Tytół strony")]
        public string Tytul { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Display(Name = "Pozycja wyświetlania")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Pozycja { get; set; }



    }
}
