using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC6ambatch13_2020.Models;
namespace MVC6ambatch13_2020.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public string getName(int id)
        // {
        //     return "Harika is Our Old Employee and Her Employee id is "+id;
        // }
        //public string getName(int id,string Name,int year)
        //{
        //    return Name+" is Our Old Employee and Her Employee id is " + id +" And Working for "+year;
        //}?Name=harika&year=2020

        public string getName(int id)
        {
            return Request.QueryString["Name"] + " is Our Old Employee and Her Employee id is " + id + " And Working for " + Request.QueryString["year"];
        }

        public ActionResult GetView() {

            return View();
        }

        public ActionResult GetView2()
        {

            return View("GetMyWishView");
        }

        public ActionResult GetView3()
        {

            return View("~/Views/New/Index.cshtml");
        }

        public ActionResult SendData() {
            ViewBag.info ="Harika";
            return View();
        }
        public ActionResult SendEmpInfo()
        {
            //ViewData["key"] = "value";

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Harika";
            obj.EmpSalary = 89000;



            ViewBag.empinfo = obj;



            return View();
        }

        public ActionResult SendAllEmpInfo()
        {
            List<EmployeeModel> emplist = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Harika";
            obj.EmpSalary = 89000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "ritu";
            obj1.EmpSalary = 34543;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 1213;
            obj2.EmpName = "Ashiwini";
            obj2.EmpSalary = 855535;

            emplist.Add(obj);
            emplist.Add(obj1);
            emplist.Add(obj2);

            ViewBag.empinfo = emplist;


            return View();
        }

        public ActionResult sendOneRecordViewModel() {

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Harika";
            obj.EmpSalary = 89000;

            //object model=obj; conneted code
            return View(obj);

        }
    }
}

//Controller/ActionMEthod/id

    //Employee/getName