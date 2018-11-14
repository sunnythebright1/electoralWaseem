using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ElectoralSystem
{
    public class Connection
    {
        static SqlConnection con;
        public static SqlConnection connect()
        {
            if (con==null)
            {
                con = new SqlConnection();
                con.ConnectionString= @"server =.; database = Fyp_electoral_populated;MultipleActiveResultSets=true; integrated security = True";
                con.Open();
            }
            return con;
        }
    }
}