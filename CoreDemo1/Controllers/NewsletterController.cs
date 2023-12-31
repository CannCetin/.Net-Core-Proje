﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo1.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager nm = new NewsletterManager (new EfNewsletterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(Newsletter p)
        {
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
