using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo5.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Minimum lenth for name is 6 characters")]
        public string Name { get; set; }
        public string Category { get; set; }

        public string Code { get; set; }
        
    }
}
