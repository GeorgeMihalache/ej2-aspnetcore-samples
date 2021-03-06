﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class RichtextEditorController : Controller
    {
        public IActionResult Print()
        {
            ViewBag.items = new[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments",
                "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "|", "SourceCode", "Undo", "Redo", "Print" };
            return View();
        }
    }
}
