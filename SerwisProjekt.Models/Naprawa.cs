using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SerwisProjekt.Models
{
    public class Naprawa
    {
        [Key]
        public int NaprawaId { get; set; }
        public DateTime Data { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Kwota { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public int SerwisantId { get; set; }
        [Required]
        public int KlientId { get; set; }

        public virtual Klient Klient { get; set; }
        public virtual Serwisant Serwisant { get; set; }
        public virtual StatusNaprawy StatusNaprawy { get; set; }
    }
}
