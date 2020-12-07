using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSIS.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "M Number is required")]
        [RegularExpression(@"\d{8}")]
        public int MNumber { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Resume { get; set; }
        public string LinkedIn { get; set; }
    }
}
