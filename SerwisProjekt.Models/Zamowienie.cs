using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SerwisProjekt.Models
{
    public class Zamowienie
    {
        [Key]
        public int ZamId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal KwotaZam { get; set; }
        [Required]
        public int NaprawaId { get; set; }
        [Required]
        public int ZamStatusId { get; set; }
        [Required]
        public int PracownikId { get; set; }

        public virtual Pracownik Pracownik { get; set; }
        public virtual Naprawa Naprawa { get; set; }
        public virtual StatusZam StatusZam { get; set; }
    }
}
