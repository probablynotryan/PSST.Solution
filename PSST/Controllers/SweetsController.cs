using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Treats.Models;
using Treats.ViewModels;

namespace Treats.Controllers
{
  [Authorize]
  public class SweetsController : Controller
  {
    private readonly TreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public SweetsController(UserManager<ApplicationUser> userManager, TreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    
    public ActionResult Index()
    {
      return View(_db.Sweets.ToList());
    }

      public ActionResult Create()
      {
        return View();
      }

      [HttpPost]
      public ActionResult Create(Sweet sweet)
      {
        _db.Sweets.Add(sweet);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

      [HttpPost]
      public ActionResult Delete(int id)
      {
        var thisSweet = _db.Sweets.FirstOrDefault(s => s.SweetId == id);
        _db.Sweets.Remove(thisSweet);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

    public ActionResult Edit(int id)
    {
      var thisSweet = _db.Sweets.FirstOrDefault(s => s.SweetId == id);
      return View(thisSweet);
    }

    [HttpPost]
    public ActionResult Edit(Sweet sweet)
    {
      _db.Entry(sweet).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    } 
  }
}