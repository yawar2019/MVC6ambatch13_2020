using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNEtExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public int Save(EmployeeModel obj) {

            SqlCommand cmd = new SqlCommand("spr_InsertEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            return i;

        }
    }
}