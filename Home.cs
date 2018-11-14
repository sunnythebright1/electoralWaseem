using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectoralSystem.Models
{
    public class Home
    {
        public int EID { get; set; }
        public decimal NIC_No { get; set; }
        public string privilege { get; set; }
        public void getData()
        {
            SqlCommand cmd = new SqlCommand("Select Privilege from Credentials where EID =2", Connection.connect());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                privilege = reader["Privilege"].ToString();
           
                    }
        }
    }
}