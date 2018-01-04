using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Bootstrap.Models
{
    public class Employee
    {
        [DisplayName("Enter Your First Name")]
        [Required(ErrorMessage = "Please Enter First Name!!!!!!!!!!")]
        public string FirstName { get; set; }

        [DisplayName("Enter Your Last Name")]
        [Required(ErrorMessage = "Please Enter Last Name!!!!!!!!!!")]
        public string LastName { get; set; }

        [DisplayName("Enter Your Age")]
        [Required(ErrorMessage = "Please Enter Age!!!!!!!!!!")]
        public int Age { get; set; }
    }
}