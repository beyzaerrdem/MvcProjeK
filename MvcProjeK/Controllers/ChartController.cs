using MvcProjeK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeK.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<ChartClass> BlogList()
        {
            List<ChartClass> ct = new List<ChartClass>();
            ct.Add(new ChartClass()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            ct.Add(new ChartClass()
            {
                CategoryName = "Matematik",
                CategoryCount = 10
            });
            return ct;

        }
    }
}