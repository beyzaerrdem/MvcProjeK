using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeK.Controllers
{
    public class SkillCardController : Controller
    {
        SkillManager sm = new SkillManager(new EFSkillDal());
        // GET: SkillCard
        public ActionResult Index()
        {
            var skillvalues = sm.GetList();
            return View(skillvalues);
        }

    }
}