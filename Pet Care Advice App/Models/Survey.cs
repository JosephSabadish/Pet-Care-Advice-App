using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetCareAdviceApp.Models
{
    public class Survey
    {
        static private List<Survey> surveys = new List<Survey>();

        //SurveySubmit
        public static List<Survey> SurveySubmit()
        {
            return surveys;
        }


        //[Required]
        //[StringLength(9, MinimumLength = 5)]
        //[RegularExpression(@"Aaaaa")]
        //public string WalkAmount { get; set; }

        //[Required]
        //[StringLength(9, MinimumLength = 5)]
        //[RegularExpression(@"Aaaaa")]
        //public string VetAmount { get; set; }

        //[Required]
        //[StringLength(9, MinimumLength = 5)]
        //[RegularExpression(@"Aaaaa")]
        //public string GroomAmount { get; set; }

        //[Required]
        //[StringLength(2, MinimumLength = 1)]
        //[RegularExpression(@"AA")]
        //public string PetNumber { get; set; }

        //[Required]
        //[StringLength(9, MinimumLength = 5)]
        //[RegularExpression(@"Aaaaa")]
        //public string PetTypeNumber { get; set; }

        //[Required]
        //[StringLength(2, MinimumLength = 1)]
        //[RegularExpression(@"AA")]
        //public string AccessoryNumber { get; set; }

        //[Required]
        //[StringLength(9, MinimumLength = 5)]
        //[RegularExpression(@"Aaaaa")]
        //public string FeedAmount { get; set; }

        //[Required]
        //[StringLength(9, MinimumLength = 5)]
        //[RegularExpression(@"Aaaaa")]
        //public string MaintainAmount { get; set; }

        //Redirect(HomeController/Results)
    }
}
