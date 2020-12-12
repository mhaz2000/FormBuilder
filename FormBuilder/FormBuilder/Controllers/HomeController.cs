using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.DTOs;
using Services.GetInfoService;

namespace FormBuilder.Controllers
{
    public class HomeController : Controller
    {
        private IGettingInfoService _gettingInfoService;
        public HomeController(IGettingInfoService gettingInfoService)
        {
            _gettingInfoService = gettingInfoService;
        }
        public ActionResult Index()
        {
            return View(_gettingInfoService.GetAllFormInfo());
        }
    }
}