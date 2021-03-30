using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BCG_Orgbuilder.Models
{
    public class Api
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "The length should be less than 250 characters")]
        public string HowTo { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}
