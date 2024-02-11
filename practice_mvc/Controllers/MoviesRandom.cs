using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practice_mvc.Models;

namespace practice_mvc.Controllers
{
    public class MoviesController : Controller 
    {
        public ActionResult Random()
        {
            return View();
        }
    }
}