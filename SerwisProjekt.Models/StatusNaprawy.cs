using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SerwisProjekt.Models
{
    public class StatusNaprawy
    {
        [Key]
        public int StatusId { get; set; }
        [Required]
        [MaxLength(20)]
        public string NazwaStatusu { get; set; }
        [Required]
        [MaxLength(50)]
        public string OpisStatusu { get; set; }

        public virtual ICollection<Naprawa> Naprawa { get; set; }
    }
}
