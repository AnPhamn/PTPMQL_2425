using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;
namespace DEMOMVC.Controllers{
    public class PersonController : Controller{
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index ( Person ps)
        {
            String Str0utput = "xin chao" + ps.PersonId + "_" + ps.FullName + "_" + ps.Address;
            ViewBag.inforPerson = Str0utput;
            return View();
        }
    }
}