using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetCareAdviceApp.ViewModels
{
    public class SurveyViewModels
    {
        [Required]
        [Display(Name = "How often do you walk your pets?")]
        [StringLength(8)]
        [MaxLength(8)]
        [MinLength(5)]
        public string WalkAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How often are your pets taken to a vet?")]
        [StringLength(8)]
        [MaxLength(8)]
        [MinLength(5)]
        public string VetAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How often are your pets groomed?")]
        [StringLength(8)]
        [MaxLength(8)]
        [MinLength(5)]
        public string GroomAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How many pets do you have?")]
        [StringLength(2)]
        [MaxLength(2)]
        [MinLength(1)]
        public string PetNumber { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How many of each pet do you have?")]
        [StringLength(2)]
        [MaxLength(2)]
        [MinLength(1)]
        public string PetTypeNumber { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How many pet accessories do you have?")]
        [StringLength(1)]
        [MaxLength(2)]
        [MinLength(1)]
        public string AccesoryNumber { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How often do you feed your pets?")]
        [StringLength(8)]
        [MaxLength(5)]
        [MinLength(5)]
        public string FeedAmount { get; set; }
        //Redirect(Home/Login) If there are errors, reload the login screen and show them.
        //Redirect(Home/Results) If no errors, redirect to the results screen.

        [Required(ErrorMessage = "Please enter the right number of characters")]
        [Display(Name = "How often do you maintain your pet living quarters?")]
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
