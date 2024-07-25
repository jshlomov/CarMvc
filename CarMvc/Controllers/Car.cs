using Microsoft.AspNetCore.Mvc;

namespace CarMvc.Controllers
{
    public class Car : Controller
    {


        public IActionResult Model(string year = "2015", string name = "mazda", string color = "red")
        {
            var car = new Models.Car()
            {
                Year = year,
                Name = name,
                Color = color
            };
            return View(car);
        }
    }
}
