using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SerwisProjekt.Models
{
    public class Klient
    {
        [Key]
        public int KlientId { get; set; }
        [Required]
        [MaxLength(20)]
        public string ImieNazwisko { get; set; }
        [MaxLength(20)]
        public string NumerTel { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(24)]
        public byte[] Haslo { get; set; }

        public virtual ICollection<Naprawa> Naprawa { get; set; }
    }
}
