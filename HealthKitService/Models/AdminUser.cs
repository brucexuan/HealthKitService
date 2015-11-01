using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthKitService.Models
{
    public class AdminUser
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string RealName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}