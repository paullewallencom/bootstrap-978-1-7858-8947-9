﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter3.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Basic()
        {
            return View();
        }

        public IActionResult Inline()
        {
            return View();
        }

        public IActionResult Horizontal()
        {
            return View();
        }
    }
}
