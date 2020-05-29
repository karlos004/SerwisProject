using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SerwisProjekt.Models
{
    public class Serwisant
    {
        [Key]
        public int SerwisantId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ImieNazwisko { get; set; }

        public virtual ICollection<Naprawa> Naprawa { get; set; }
    }
}
