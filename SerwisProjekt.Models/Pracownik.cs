using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SerwisProjekt.Models
{
    public class Pracownik
    {
        [Key]
        public int PracownikId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ImieNazwiskoPracownika { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
