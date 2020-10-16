﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC6ambatch13_2020.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

    }

    public class EmpDept
    {
        public List<EmployeeModel> Emp { get; set; }
        public DepartmentModel Dept { get; set; }
    }
}