using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumingWebSerice.ServiceReference1;
namespace ConsumingWebSerice.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            MyCaclculatorSeviceSoapClient obj = new MyCaclculatorSeviceSoapClient();
            obj.Add(12, 16);

            return Content(obj.Add(12, 16).ToString());
        }
    }
}