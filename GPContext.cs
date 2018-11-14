
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElectoralSystem.Models
{
    public class GPContext : DbContext
    {
        public DbSet<GeneralPublic> Publics { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        
    }
}   