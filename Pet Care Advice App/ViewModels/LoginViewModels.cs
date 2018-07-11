using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetCareAdviceApp.ViewModels
{
    public class LoginViewModels
    {
        [Required]
        [Display(Name = "Enter User Name")]
        public string Name { get; set; }
    
    
        [Required]
        [Display(Name = "Enter your password")]
        public string Password { get; set; }
    }
}
