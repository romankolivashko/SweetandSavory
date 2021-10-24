using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetAndSavory.Controllers
{
    public class HomeController : Controller
    {

      // [HttpGet("/")]
      // public ActionResult Index()
      // {
      //   return View();
      // }

      private readonly SweetAndSavoryContext _db;

      public HomeController(SweetAndSavoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.AllTreatsList = _db.Treats.ToList();
        ViewBag.AllFlavorsList = _db.Flavors.ToList();
        return View();
      }

    }
}