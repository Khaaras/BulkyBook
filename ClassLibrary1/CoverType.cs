using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class CoverType
    {
        public int Id { get; set; }
        [Display(Name = "Cover Type Name")]
        [Required]
        [MaxLength(50, ErrorMessage = "Name of cover type must be less than 50 letters")]
        public string Name { get; set; }
    }
}
