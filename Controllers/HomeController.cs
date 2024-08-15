//using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
//using FirstProject.Models;

namespace FirstProject.Controllers
{

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "GoodMorning" : "GoodAfternoon";
            
            return View("MyView",viewModel);
        }
    }

}