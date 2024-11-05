using Microsoft.AspNetCore.Mvc;
using Circle.Models;

namespace Circle.Controllers
{
    public class CircleController : Controller
    {
        public IActionResult Index()
        {

            return View(new CircleModel());
        }


        [HttpPost]
        public IActionResult Calculate(CircleModel model)
        {
            double pi = 3.14159;


            if (model.Radius <= 0)
            {
                ViewData["ErrorMessage"] = "Yaricap değeri pozitif bir sayi olmali";
                return View("Index", model);
            }

            model.Area = pi * model.Radius * model.Radius;


            ViewData["ErrorMessage"] = null;

            return View("Index", model);
        }



    }
}
