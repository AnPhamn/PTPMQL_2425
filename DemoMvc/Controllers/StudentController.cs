using Microsoft.AspNetCore.Mvc;
namespace DEMOMVC.Controllers;


public class StudentController : Controller
{
   public IActionResult Index()
    {
        return View();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult Index(string MaSinhVien, string HoTen)
    {
        string strResult = "Xin chao " + MaSinhVien + "-" + HoTen;
        ViewBag.Info = strResult;
        return View();
    }
}