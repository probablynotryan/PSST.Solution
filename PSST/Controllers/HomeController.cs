using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Treats.Models;

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
      return View();
    }
  }
}