using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class DuvidasController : Controller
    {
        public IActionResult Duvidas()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Duvidas"
            });
        }
    }
}