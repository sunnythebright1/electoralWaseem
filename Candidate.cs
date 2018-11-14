using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace ElectoralSystem.Models
{   
    [Table("Applied_Candidates")]
    public class Candidate
    {
      //  Candidate can;
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Display(Name="NIC_NO")]
        public decimal NIC_No { get; set; }
        [Display(Name = "Name")]

        public string Name { get; set; }
        [Display(Name = "CandidateNo")]

        public decimal CandidateNo;
        public string partyName;
        public string Area;
        public string City;
        public string assemblyType;
        public int assemblyNo;
        public int pollingCounters;
        public int voteCount;
        
        public void getConstituency()
        {   
            SqlCommand cmd = new SqlCommand("stp_getConstituency", Connection.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NIC", NIC_No);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
               CandidateNo = (decimal)reader[0];
                Name = (string)reader[1];
                partyName = (string)reader[2];
                Area = (string)reader[3];
                City = (string)reader[4];
                assemblyType = (string)reader[5];
                assemblyNo = Convert.ToInt32(reader[6]);
                pollingCounters = (int)reader[7];
                voteCount = (int)reader[8];
                
            }
           // return can;
        }
    }
}