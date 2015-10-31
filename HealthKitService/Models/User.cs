using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthKitService.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public string RegisterWay { get; set; }

        // Foreign Key
        public int? UserDetailsId { get; set; }
        // Navigation property
        public UserDetails UserDetails { get; set; }
    }
}