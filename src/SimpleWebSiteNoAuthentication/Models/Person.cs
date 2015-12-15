using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebSiteNoAuthentication.Models
{
    public class Person
    {
        [Required]
        [StringLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(5)]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
