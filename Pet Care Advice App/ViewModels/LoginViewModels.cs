using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetCareAdviceApp.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Please enter at least 6 characters.")]
        [StringLength(6)]
        public string Name { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter at least 6 characters")]
        [StringLength(6)]
        public string Password { get; set; }
        //Redirect(Home/Login)  If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.
        
        //The user sees erros from this page,
        //If there are any in the Login form,
        //ViewBag.Login
        //List<Login> = new list login

    }
}
