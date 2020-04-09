using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SerwisProjekt.Models
{
    public class Repair
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(17)]
        public string Vin { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public int MechanicId { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}
