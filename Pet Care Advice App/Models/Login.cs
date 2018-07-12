using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetCareAdviceApp.Models
{
    public class Login
    {
        static private List<Login> logins = new List<Login>();
    
        // ManagerLogin
        public static List<Login> ManagerLogin()
        {
            return logins;
        }

       
        //SAVE THE CODE BELOW THIS LINE. MAY STILL BE USEFUL
        //[Required]
        //[StringLength(10, MinimumLength = 6)]
        //[RegularExpression(@"Aaaaa")]
        //public string Name { get; set; } //Don't alter this 

        //[Required]
        //[StringLength(10, MinimumLength = 6)]
        //public string Password { get; set; } //Don't alter this
       

        //Redirect(HomeController/Results)

        //Create a ViewBag object
        //public Login(string name, string password) //Don't alter this
        // {
        //Username = name; //Don't alter this
        //Password = password; //Don't alter this
        //}
        //public Login() { }
    }
}
