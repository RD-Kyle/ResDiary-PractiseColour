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
                Session["colours"] = new List<Colour> { new Colour { Id = 1, Name = "Red" } };

            return View();
        }

        [HttpPost]
        public JsonResult AddColour(Colour colourInput)
        {
            var newId = 0;
            var colourList = ((List<Colour>)(Session["colours"]));
            if (colourList.Count != 0)
            {
                newId = colourList[colourList.Count - 1].Id + 1;
            }

            colourInput.Id = newId;

            colourList.Add(colourInput);

            return GetColours();
        }
        
        [HttpGet]
        public JsonResult GetColours()
        {
            var colours = GetIndexVM();

            return Json(colours, JsonRequestBehavior.AllowGet);
        }

        private IndexViewModel GetIndexVM()
        {
            if (Session["colours"] == null)
                Session["colours"] = new List<Colour>();

            var vm = new IndexViewModel { Colours = new List<Colour>() };
            foreach (var c in (List<Colour>)Session["colours"])
            {
                vm.Colours.Add(c);
            }

            return vm;
        }

        [HttpPost]
        public JsonResult RemoveColour(int Id)
        {
            var colourList = ((List<Colour>)(Session["colours"]));
            var destColour = colourList.Find(c => c.Id == Id);
            colourList.Remove(destColour);
            return GetColours();
        }

        [HttpPost]
        public JsonResult SaveColour(Colour SavedColour)
        {
            var colourList = ((List<Colour>)(Session["colours"]));
            var colourToEdit = colourList.Find(c => c.Id == SavedColour.Id);
            colourToEdit.Name = SavedColour.Name;
            return GetColours();
        }
    }
}