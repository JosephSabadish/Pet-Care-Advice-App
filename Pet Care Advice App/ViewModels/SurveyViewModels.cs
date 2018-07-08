using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetCareAdviceApp.ViewModels
{
    public class SurveyViewModels
    {
        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(8)]
        [MaxLength(8)]
        [MinLength(5)]
        public string WalkAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(8)]
        [MaxLength(8)]
        [MinLength(5)]
        public string VetAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(8)]
        [MaxLength(8)]
        [MinLength(5)]
        public string GroomAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(2)]
        [MaxLength(2)]
        [MinLength(1)]
        public string PetNumber { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(2)]
        [MaxLength(2)]
        [MinLength(1)]
        public string PetTypeNumber { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(1)]
        [MaxLength(2)]
        [MinLength(1)]
        public string AccesoryNumber { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(8)]
        [MaxLength(5)]
        [MinLength(5)]
        public string FeedAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [StringLength(8)]
        [MaxLength(5)]
        [MinLength(5)]
        public string MaintainAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        //Validate code and show other error messages.
        //(Error.IsValid.ShowAll)
        
        //The user sees errors from this page if there are any
        //in the Survey form.
        
        //ViewBag(survey)
        //List<Survey> = new List <survey>





    }
}
