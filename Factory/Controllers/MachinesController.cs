using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "View All Machines";
      List<Machine> MachineList = _db.Machines.Include(machine => machine.JoinEntities)
          .ThenInclude(join => join.Machine).OrderByDescending(machine => machine.JoinEntities.Count).ToList();

      return View(MachineList);
    }

    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
          .Include(machine => machine.JoinEntities)
          .ThenInclude(join => join.Machine)
          .FirstOrDefault(machine => machine.MachineId == id);
      ViewBag.PageTitle = $"{thisMachine.Name} Details";
      return View(thisMachine);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add Machine";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine Machine)
    {
      _db.Machines.Add(Machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}