using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumingWebSerice.ServiceReference1;
using ConsumingWebSerice.ServiceReference2;
namespace ConsumingWebSerice.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            MyCaclculatorSeviceSoapClient obj = new MyCaclculatorSeviceSoapClient();
            obj.Add(12, 16);

            ServiceReference2.Service1Client obj1 = new ServiceReference2.Service1Client();
            obj1.Add(25, 25);

            return Content(obj1.Add(25, 25).ToString());
        }
        public ActionResult SendMethod() {

            TempData["Student"] = "Malakonda";
            return RedirectToAction("ReceiveMethod");
        }
        public ActionResult ReceiveMethod()
        {

            //string stdentName=Convert.ToString(TempData["Student"]);
            //TempData.Keep();
            string stdentName=TempData.Peek("Student").ToString();
      

            return Content(stdentName);
        }
    }
}