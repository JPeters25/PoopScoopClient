using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PoopScoopClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PoopScoopClient.Controllers
{
  public class PoopsController : Controller
  {
    public IActionResult Index()
    {
      var allPoops = Poop.GetPoops();
      return View(allPoops);
    }

    [HttpPost]
    public IActionResult Index(Poop poop)
    {
      Poop.Post(poop);
      return RedirectToAction("Index");
    }

    public IActionResult Color(string color)
    {
      var poopColors = Poop.GetColor(color);
      return View(poopColors);
    }

    [HttpPost]
    public IActionResult Color(Poop poop)
    {
      Poop.Post(poop);
      return RedirectToAction("Index");
    }



    public IActionResult Details(int id)
    {
      var poop = Poop.GetDetails(id);
      return View(poop);
    }

    [HttpPost]
    public IActionResult Details(int id, Poop poop)
    {
      poop.PoopId = id;
      Poop.Put(poop);
      return RedirectToAction("Color", id);
    }

    public IActionResult Edit(int id)
    {
      var poop = Poop.GetDetails(id);
      return View(poop);
    }

    public IActionResult Delete(int id)
    {
      Poop.Delete(id);
      return RedirectToAction("Index");
    }


  }
}