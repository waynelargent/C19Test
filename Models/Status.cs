using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C19Test.Models
{
    public class Status
    {
        public int StatusID { get; set; }

        [StringLength(100)]
        [Required]
        public string Description { get; set; }
    }
    
    
    
}
