using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C19Test.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        [StringLength(100)]
        [Required]
        public string LocationDescription { get; set; }
    }
}
