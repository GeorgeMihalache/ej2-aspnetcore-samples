﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.TreeMap
{
    public partial class TreeMapController : Controller
    {
        public IActionResult SelectionAndHighlight()
        {
            ViewBag.dataSource = this.getDataSource("Imports");
            return View();
        }
    }
}