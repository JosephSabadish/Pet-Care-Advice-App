using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pet_Care_Advice_App.Models;
using PetCareAdviceApp.ViewModels;

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
            ViewData["Message"] = "What this application does:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {
            LoginViewModels loginViewModel = new LoginViewModels();
            return View(loginViewModel);
        }


        [HttpPost]
        public IActionResult Login(LoginViewModels loginViewModel) //Methods a manager uses to login
        {
            HomeController newLogin = new HomeController {
                  Name = loginViewModel.Name,
                  Password = loginViewModel.Password
            };

            Login.Login(newLogin);
            // List of login information

            return Redirect("/HomeController"); //Returns the Login view with the lognis parameter as a variable
        }

        
        public IActionResult Survey()
        {
            return View();
        }

        public IActionResult Results()
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
