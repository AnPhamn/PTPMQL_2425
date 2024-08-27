using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;
namespace DEMOMVC.Controllers{
    public class PersonController : Controller{
        // Hiển thị dữ liệu từ controller lên view
        public IActionResult Index () 
        {
            return View();
        }
        [HttpPost]
        // Trả dữ liệu từ View về controller 
        public IActionResult Index ( Person ps)
        {
            String strResult = "xin chao" + ps.PersonId + "_" + ps.FullName + "_" + ps.Address;
            ViewBag.inforPerson = strResult;
            return View();
        }
    }
}