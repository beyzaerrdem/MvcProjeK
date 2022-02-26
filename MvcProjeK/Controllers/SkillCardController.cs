using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

        public ActionResult ListSkill()
        {
            var skillvalues = sm.GetList();
            return View(skillvalues);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            sm.SkillAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill p)
        {
            sm.SkillUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var skillvalues = sm.GetById(id);
            sm.SkillDelete(skillvalues);
            return RedirectToAction("Index");
        }
    }
}