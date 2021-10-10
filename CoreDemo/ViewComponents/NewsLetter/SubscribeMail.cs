﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.NewsLetter
{
    public class SubscribeMail : ViewComponent
    {
        
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.BlogID = id;
            EntityLayer.Concrete.NewsLetter newsLetter = new EntityLayer.Concrete.NewsLetter();
            return View(newsLetter);
        }
    }
}