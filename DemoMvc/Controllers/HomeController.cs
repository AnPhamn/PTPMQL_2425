using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DEMOODMVC.Controllers;

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
