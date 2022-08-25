using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

// namespace Factory.Controllers
// {
//   [Authorize]
//   public class MachinesController : Controller
//   {
//     private readonly FactoryContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;

//     public MachinesController(UserManager<ApplicationUser> userManager, FactoryContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     public async Task<ActionResult> Index()
//     {
//       var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       var currentUser = await _userManager.FindByIdAsync(userId);
//       var userMachines = _db.Machines.Where(entry => entry.User.Id == currentUser.Id).ToList();
//       return View(userMachines);
//       // return View(_db.Machines.ToList());
//     }

//     public ActionResult Create()
//     {
//       ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
//       return View();
//     }

//     [HttpPost]
//     public async Task<ActionResult> Create(Machine machine)
//     {
//       var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       var currentUser = await _userManager.FindByIdAsync(userId);
//       machine.User = currentUser;
//       _db.Machines.Add(machine);
//       _db.SaveChanges();

//     //   if (EngineerId != 0)
//     // {
//     //     _db.EngineerRecipe.Add(new EngineerRecipe() { EngineerId = EngineerId, RecipeId = recipe.RecipeId });
//     // }
//     // _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//       ViewBag.Engineers = _db.Engineers.ToList();
//       var thisMachine = _db.Machines
//           .Include(machine => machine.JoinEntities)
//           .ThenInclude(join => join.Engineer)
//           .FirstOrDefault(machine => machine.MachineId == id);
//       return View(thisMachine);
//     }

//     public ActionResult Edit(int id)
//     {
//       var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
//       ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
//       return View(thisMachine);
//     }

//     [HttpPost]
//     public ActionResult Edit(Machine machine, int EngineerId)
//     {
//       if (EngineerId != 0)
//       {
//         _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
//       }
//       _db.Entry(machine).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult AddEngineer(int id)
//     {
//       var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
//       ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
//       return View(thisMachine);
//     }

//     [HttpPost]
//     public ActionResult AddEngineer(Machine machine, int EngineerId)
//     {
//       if (EngineerId != 0)
//       {
//         _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
//         _db.SaveChanges();
//       }
//       return RedirectToAction("Index");
//     }

//     public ActionResult Delete(int id)
//     {
//       var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
//       return View(thisMachine);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
//       _db.Machines.Remove(thisMachine);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     [HttpPost]
//     public ActionResult DeleteEngineer(int joinId)
//     {
//       var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
//       _db.EngineerMachine.Remove(joinEntry);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }