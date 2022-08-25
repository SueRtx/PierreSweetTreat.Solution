using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PierreBakery.Models;

namespace PierreBakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreBakeryContext _db;
    public HomeController(PierreBakeryContext db)
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