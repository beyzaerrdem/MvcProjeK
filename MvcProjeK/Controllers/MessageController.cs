using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeK.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMassageDal());
        ContactManager cm = new ContactManager(new EFContactDal());
        MessageValidatior messageValidatior = new MessageValidatior();

        // GET: Message
        [Authorize]
        public ActionResult Inbox(string p)
        {
            var messageList = mm.GetListInbox(p);

            return View(messageList);
        }

        public ActionResult SendBox(string p)
        {
            var messageList = mm.GetListSendBox(p);
            return View(messageList);
        }

        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            values.IsReading = true;
            mm.MessageUpdate(values);
            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            values.IsReading = true;
            mm.MessageUpdate(values);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            
            ValidationResult results = messageValidatior.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Now;
                mm.MessageAdd(p);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}