using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShiftSchedule.UI.MVC.ViewModels
{
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "You must Enter First Name")]
        [MaxLength(150, ErrorMessage = "Maximum {0} characters")]
        [MinLength(2, ErrorMessage = "Minimum {0} characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must Enter Last Name")]
        [MaxLength(150, ErrorMessage = "Maximum {0} characters")]
        [MinLength(2, ErrorMessage = "Minimum {0} characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "You must Enter E-mail")]
        [MaxLength(150, ErrorMessage = "Maximum {0} characters")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }
        public bool AdminRights { get; set; }
    }
}