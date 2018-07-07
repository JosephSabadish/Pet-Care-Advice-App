using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pet_Care_Advice_App.Models;

namespace Pet_Care_Advice_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login() //Methods a manager uses to login
        {
            // List of login information

            return View(); //Returns the Login view with the logins parameter as a variable
        }

        public IActionResult Survey()
        {
            return View();
        }
    }
}
//Post request that lets the user login and see the results.

//public IActionResult Survey()
//{
//    return View();
//}
//Results from the survey get redirected to the Results view via "Post" request.
//[Redirect("/Client/SurveyError")]   //Redirect ("Client/Error") If errors are found, redirect to the error page
//ErrorMessage = ""


//public IActionResult Results()
//{
//    return View();
//}

//public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
