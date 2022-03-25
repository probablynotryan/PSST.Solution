using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Treats.Models;

namespace PSST.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatContext _db;
    public HomeController(TreatContext db)
    {
      _db = db;
    }
  }
}