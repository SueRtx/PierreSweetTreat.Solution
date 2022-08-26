using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SavorySweets.Models;

namespace SavorySweets.Controllers
{
  public class HomeController : Controller
  {
    private readonly SavorySweetsContext _db;
    public HomeController(SavorySweetsContext db)
    {
      _db = db;
    } 

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
  }
}