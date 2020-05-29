using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SerwisProjekt.Models
{
    public class StatusZam
    {
        [Key]
        public int ZamStatusId { get; set; }
        [Required]
        public string NazwaStatusuZam { get; set; }
        [Required]
        public string OpisStatusuZam { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
