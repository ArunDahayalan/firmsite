﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tirelesspeople.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult Contactus()
        {
            return View();
        }
    }
}