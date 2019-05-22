using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetLab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Registration()
        {
            ViewBag.Message = "Your information.";

            return View();
    
        }
        public ActionResult Welcome(FormModel user)
        {
            
            ViewBag.FirstName = user.FirstName;
            ViewBag.Email = user.Email;
            ViewBag.Password = user.Password;
            
            if (user.Cat == "Cat")
            {
                ViewBag.Cat = "You have a cat. Purrfect!";
            }
            else
            {
                ViewBag.Cat = "You don't have a cat! Meow's the time to get one.";
            }
            if (user.Dog == "Dog")
            {
                ViewBag.Dog = "You have a dog. Woof!";
            }
            else
            {
                ViewBag.Dog = "You don't have a dog! That bites.";
            }
            if (user.Bantha == "Bantha")
            {
                ViewBag.Bantha = "You have a bantha. The force is strong with you!";
            }
            else
            {
                ViewBag.Bantha = "You don't have a bantha. There might be one on eBay.";
            }


            return View();

            

        }

    }
}