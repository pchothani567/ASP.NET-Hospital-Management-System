using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Project_Hospital
{
    public class BookAppointment
    {
        string s = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public void startcon()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        public void insert(string nm,string eml,string date,string time,string s1,string s2,string s3,string s4,string s5,string bloodgroup,string phoneno)
        {
            cmd = new SqlCommand("insert into BookAppointment(Name,Email,Date,Time,Fever,Cough,Headache,Fatigue,Other,BloodGroup,PhoneNo)values('" + nm + "','"+ eml+"','"+date+"','"+time+"','"+s1+"','"+s2+"','"+s3+"','"+s4+"','"+s5+"','"+bloodgroup+"','"+phoneno+"')",con);
            cmd.ExecuteNonQuery();           
        }

    }
}
