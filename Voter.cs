using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ElectoralSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectoralSystem.Models
{
    public class Voter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal NIC { get; set; }
        public string Name { get; set; }
        public int areaCode { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public int naNo { get; set; }
        public string assemblyAlias { get; set; }
        public int paNo { get; set; }
        public void getVoter()
        {
            SqlCommand cmd = new SqlCommand("stp_votingDetails", Connection.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NIC", NIC);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Name = (string)reader[0];
                areaCode = (int)reader[1];
                Area = (string)reader[2];
                City = (string)reader[3];
                naNo = (int)reader[4];
                assemblyAlias = (string)(reader[5]);
                paNo = (int)reader[6];

            }
        }

    }
    
}