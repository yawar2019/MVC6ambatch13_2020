using AdoDotNEtExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoDotNEtExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        EmployeeContext db = new EmployeeContext();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel obj)
        {
            int i = db.Save(obj);
            if (i > 0) {
                ViewBag.msg = "Inserted Successfully";
            }
            else
            {
                ViewBag.msg = "Failed to Insert Record";

            }
            return View();
        }
    }
}