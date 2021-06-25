using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ToDoList.Infrastructure
{
    public class db
    {
        SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=ToDoContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        public DataTable GetRecord()
        {
            SqlCommand com = new SqlCommand("select * from ToDoList", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetSelectedRecords()
        {
            SqlCommand com = new SqlCommand("select * from ToDoList", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
