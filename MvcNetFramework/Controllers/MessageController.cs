using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNetFramework.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator validatior = new MessageValidator();
        public ActionResult Inbox()
        {
            var messageValue = messageManager.GetListInbox();
            return View(messageValue);
        }
        public ActionResult Sendbox()
        {
            var messageValue = messageManager.GetListSendbox();
            return View(messageValue);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {

            ValidationResult result = validatior.Validate(message);
            if (result.IsValid)
            {
                message.MessageDate = DateTime.Now;
               messageManager.MessageAdd(message);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var value = messageManager.GetById(id);
            return View(value);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var value = messageManager.GetById(id);
            return View(value);
        }

    }
}