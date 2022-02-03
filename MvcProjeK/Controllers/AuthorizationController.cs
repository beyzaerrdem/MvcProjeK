﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeK.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager adminmanager = new AdminManager(new EFAdminDal());

        public ActionResult Index()
        {
            var adminvalues = adminmanager.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminmanager.AdminAdd(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var adminvalues = adminmanager.GetByID(id);
            return View(adminvalues);
        }

        [HttpPost]
        public ActionResult UpdateAdmin(Admin p)
        {
            adminmanager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}