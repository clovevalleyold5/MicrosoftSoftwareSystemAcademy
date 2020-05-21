using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Five.Models
{
    public class Spartan
    {
        [Required(ErrorMessage = "your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="your height")]
        public string Height { get; set; }
        [Required(ErrorMessage ="your weight")]
        public string Weight { get; set; }
        [Required(ErrorMessage ="your gender")]
        public string Gender { get; set; }
    }
}
