﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fifa.Proclube.API.Controllers
{
    public class HomeControler : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}