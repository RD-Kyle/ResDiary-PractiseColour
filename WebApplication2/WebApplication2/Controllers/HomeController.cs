using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["colours"] == null)
                Session["colours"] = new List<Colour> { new Colour { id = 0, name = "Red" } };

            return View();
        }
        
        [HttpPost]
        public ActionResult AddColour(Colour colourInput)
        {
            ((List<Colour>)(Session["colours"])).Add(colourInput);
            return new RedirectResult("/");
        }
        
        [HttpGet]
        public JsonResult GetColours()
        {
            if (Session["colours"] == null)
                Session["colours"] = new List<Colour>();

            var colours = new IndexViewModel { Colours = new List<Colour>() };
            foreach (var c in (List<Colour>)Session["colours"])
            {
                colours.Colours.Add(c);
            }

            return Json(colours, JsonRequestBehavior.AllowGet);
        }
    }
}