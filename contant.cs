using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Project_Hospital
{
    public class Contact
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

        public void insert(string nm, string eml, string sub, string msg)
        {
            cmd = new SqlCommand("insert into Contact(Name,Email,Subject,Message)values('" + nm + "','"+eml+"','"+sub+"','"+msg+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
