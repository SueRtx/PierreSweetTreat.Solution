using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PierreBakery.Models;

// namespace Factory.Controllers
// {
//   public class HomeController : Controller
//   {
//     private readonly FactoryContext _db;
//     public HomeController(FactoryContext db)
//     {
//       _db = db;
//     } 

//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       ViewBag.Engineers = _db.Engineers.ToList();
//       ViewBag.Machines = _db.Machines.ToList();
//       return View();
//     }
//   }
// }