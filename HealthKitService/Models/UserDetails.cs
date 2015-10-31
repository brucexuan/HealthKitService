using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthKitService.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Weight { get; set; }
    }
}