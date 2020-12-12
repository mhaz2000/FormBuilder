using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.DTOs;
using Services.CreateNewFormService;

namespace FormBuilder.Controllers
{
    public class CreatingFromController : Controller
    {
        private ICreatingNewFormService _service;
        public CreatingFromController(ICreatingNewFormService service)
        {
            _service = service;
        }
        // GET: CreatingFrom
        public ActionResult Create()
        {
            return View(new FormDTO());
        }

        [HttpPost]
        public ActionResult Create(FormDTO form)
        {
            _service.CreateFrom(form);
            return RedirectToAction("Index", "CreatingFrom");
        }
    }
}