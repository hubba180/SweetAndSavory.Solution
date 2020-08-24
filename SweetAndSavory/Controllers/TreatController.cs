using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SweetAndSavory.Controllers
{
  public class TreatController : Controller
  {
    private readonly SweetAndSavoryContext _db;

    public TreatController(SweetAndSavoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Flavors, "TreatId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat, int flavorId)
    {
      _db.Treats.Add(treat);
      if (flavorId != 0)
      {
        _db.FlavorTreat.Add(new FlavorTreat() { FlavorId = flavorId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      //add authentication
      var thisTreat = _db.Treats
        .Include(treat => treat.Flavors)
          .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.TreatId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat, int flavorId)
    {
      if (flavorId != 0)
      {
        _db.FlavorTreat.Add(new FlavorTreat() { FlavorId = flavorId, TreatId = treat.TreatId });
      }
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = treat.TreatId });
    }
    public ActionResult Delete(int id)
    {
      var ThisTreat = _db.Treats.FirstOrDefault(a => a.TreatId == id);
      return View(ThisTreat);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var ThisTreat = _db.Treats.FirstOrDefault(a => a.TreatId == id);
      _db.Treats.Remove(ThisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}