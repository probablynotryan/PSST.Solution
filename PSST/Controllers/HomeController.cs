using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;
using Treats.Models;
using Treats.ViewModels;

namespace Treats.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatsContext _db;

    public HomeController(TreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      ViewBag.Sweets = _db.Sweets.ToList();

      return View();
    }
  }
}