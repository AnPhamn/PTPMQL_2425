using Microsoft.AspNetCore.Mvc;

namespace DEMOMVC.Controllers;

public class HomeController : Controller
{     
    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Demo(string FullName)
    {
        string strResult = "Xin Chao" + FullName;
        ViewBag.thongbao = strResult;
        return View();
        
    }

}
