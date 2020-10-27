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
        public ActionResult Index()
        {
            
            return View(db.getEmployees());
        }

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


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel obj)
        {
            int i = db.UpdateEmployee(obj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.msg = "Failed to Update Record";

            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.msg = "Failed to Delete Record";

            }
            return View();
        }
    }
}