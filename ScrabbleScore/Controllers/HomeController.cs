using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Models;

namespace ScrabbleScore.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
    return View();
    }
    [HttpPost("/result")]
    public ActionResult Result()
    {
      ScrabbleCheck newScrabble = new ScrabbleCheck(Request.Form["scrabble"]);
      return View("result", newScrabble);
    }
  }
}
