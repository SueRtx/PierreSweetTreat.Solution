using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierreBakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

// namespace PierreBakery.Controllers
// {
//   [Authorize]
//   public class EngineersController : Controller
//   {
//     private readonly PierreBakeryContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;
//     public EngineersController(UserManager<ApplicationUser> userManager, PierreBakeryContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     public async Task<ActionResult> Index()
//     {
//       var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       var currentUser = await _userManager.FindByIdAsync(userId);
//       var userEngineers = _db.Engineers.Where(entry => entry.User.Id == currentUser.Id).ToList();

//       return View(userEngineers);
//     }

//     public ActionResult Create()
//     {
//       return View();
//     }


//     [HttpPost]
//     public async Task<ActionResult> Create(Engineer engineer)
//     {
//       var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       var currentUser = await _userManager.FindByIdAsync(userId);
//       engineer.User = currentUser;
//       _db.Engineers.Add(engineer);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//       ViewBag.Machines = _db.Machines.ToList();
//       var thisEngineer = _db.Engineers
//           .Include(engineer => engineer.JoinEntities)
//           .ThenInclude(join => join.Machine)
//           .FirstOrDefault(engineer => engineer.EngineerId == id);
//       return View(thisEngineer);
//     }
    
//     public ActionResult Edit(int id)
//     {
//       var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
//       return View(thisEngineer);
//     }

//     [HttpPost]
//     public ActionResult Edit(Engineer engineer)
//     {
//       _db.Entry(engineer).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Delete(int id)
//     {
//       var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
//       return View(thisEngineer);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
//       _db.Engineers.Remove(thisEngineer);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult AddMachine(int id)
//     {
//       var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
//       ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
//       return View(thisEngineer);
//     }

//     [HttpPost]
//     public ActionResult AddMachine(Engineer engineer, int MachineId)
//     {
//       if(MachineId != 0)
//       {
//         _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, EngineerId = engineer.EngineerId });
//         _db.SaveChanges();
//       }
//       return RedirectToAction("Details", new { id = engineer.EngineerId });
//     }

//     [HttpPost]
//     public ActionResult DeleteMachine(int joinId)
//     {
//       var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
//       _db.EngineerMachine.Remove(joinEntry);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }