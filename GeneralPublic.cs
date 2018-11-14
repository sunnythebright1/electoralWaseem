using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElectoralSystem.Models
{   [Table("General_Public")]
    public class GeneralPublic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public decimal NIC_No { get; set; }
        public string Name { get; set; }
        
    }
}