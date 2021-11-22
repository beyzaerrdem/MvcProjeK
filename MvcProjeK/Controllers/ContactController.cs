using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeK.Controllers
{
    public class ContactController : Controller
    {

        ContactManager cm = new ContactManager(new EFContactDal());
        MessageManager mm = new MessageManager(new EFMassageDal());


        ContactValidatior cv = new ContactValidatior();

        // GET: Contact
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }

        public PartialViewResult MessageListMenu()
        {
            ViewBag.ContactCount = cm.GetList().Count;
            ViewBag.InboxCount = mm.GetListInbox().Count;
            ViewBag.SendBoxCount = mm.GetListSendBox().Count;

            return PartialView();
        }
    }
}