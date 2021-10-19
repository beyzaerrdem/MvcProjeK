using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeK.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        // GET: Heading
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
    }
}