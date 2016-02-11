using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ConsoleApplication1
{
    class AccueilController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexDeux()
        {
            return View();
        }
   
    }
}
