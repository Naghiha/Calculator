using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class FibonnaciModel
    {
        [Required]
        public int Range { get; set; }
        public int Sum { get; set; }
    }
}
