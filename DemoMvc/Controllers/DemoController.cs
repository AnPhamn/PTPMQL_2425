using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Home(string FullName)
        {
        String strResult = "Xin Chao" + FullName;
        ViewBag.ABC = strResult;
        return View();
        }
    }
}