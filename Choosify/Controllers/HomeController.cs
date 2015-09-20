using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Model;
using Common.Interfaces;
using BLLLayer;

namespace Choosify.Controllers
{
    public class HomeController : Controller
    {
        private IApplicationLogic _applicationLogic;
        
        public HomeController(IApplicationLogic applicationLogic)
        {
            _applicationLogic = applicationLogic;
        }
        public ActionResult Index()
        {
            //tw.Initialize();

            List<Subject> ls = new List<Subject>{
                new Subject{Texts=new List<string>{"flipkart"}}
            };
            var analyzedMessages = _applicationLogic.GetMessagesFromAllSources(ls);
            return View();
        }
    }
}
