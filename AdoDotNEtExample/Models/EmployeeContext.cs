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

        public List<EmployeeModel> getEmployees()
        {
            List<EmployeeModel> listemp = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listemp.Add(emp);
            }
            return listemp;
        }
        public int Save(EmployeeModel obj)
        {

            SqlCommand cmd = new SqlCommand("spr_InsertEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            return i;

        }

        public EmployeeModel getEmployeeById(int? id)
        {
            EmployeeModel emp = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@empid", id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
            }
            return emp;
        }

        public int UpdateEmployee(EmployeeModel obj)
        {

            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", obj.EmpId);
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public int DeleteEmployee(int? id)
        {

            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", id);
             
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        
    }
}