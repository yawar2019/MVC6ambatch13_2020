using DBwithStoreproc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBwithStoreproc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MvcDBEntities db1 = new MvcDBEntities();
        public ActionResult Index()
        {
            return View(db1.Sp_GetEmployee());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sp_GetEmployee_Result obj)
        {
            System.Data.Entity.Core.Objects.ObjectResult i = db1.sp_insertEmployeeExample2(obj.EmpName, obj.EmpSalary, obj.EmpDesignation);
            int r = Convert.ToInt32(i);
            if (r > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }

        public ActionResult HtmlExamplle()
        {
            Sp_GetEmployee_Result db = new Sp_GetEmployee_Result();
            db.EmpName = "under taker";
            //ViewBag.Employees = new SelectList(db1.Sp_GetEmployee(), "Empid", "EmpName",4);
            ViewBag.Employees12 = new SelectList(db1.employeeDetails, "Empid", "EmpName", 4);

            return View(db);

        }
        public ActionResult ValidationExample()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidationExample(RegisterModel reg)
        {
            if (ModelState.IsValid) { return View(); }
            else
            {
                return View(reg);

            }
        }
    }
}