using MVC6ambatch13_2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6ambatch13_2020.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public PartialViewResult Index()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "MAlakona";
            obj.EmpSalary = 12000;

            return PartialView("_MyPartialView", obj);
        }
    }
}