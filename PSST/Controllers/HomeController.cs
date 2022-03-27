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
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

      var HomeModel = new UserViewModel {
        UserId = userId,
        Flavors = _db.Flavors.ToList()
          .OrderByDescending(flavor => flavor.User.Id == userId)
          .ToList(),
        Sweets = _db.Sweets
          .OrderByDescending(sweet => sweet.User.Id == userId)
          .ToList()
      };

      return View(HomeModel);
    }
  }
}