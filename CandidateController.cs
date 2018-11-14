using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectoralSystem.Models;
namespace ElectoralSystem.Controllers
{   
    
    public class CandidateController : Controller
    {
        // GET: Candidate
        Candidate cn = new Candidate();
        public ActionResult Index()
        {   
            if (TempData["canNIC"] != null)
            {
                Session["NIC"] = TempData["canNIC"];
            }
            
            TempData["Name4"] = TempData["Name3"];
            return View();
        }
        public ActionResult cResults(Candidate can)
        {
            can.NIC_No = (decimal)Session["NIC"]; //Code to generate NIC # and candidate details
            
            can.getConstituency();
           
            return View(can);
        }
        public ActionResult withdrawalRequest(Candidate can)
        {
            can.NIC_No = (decimal)Session["NIC"]; //generating candidates and its details
            
            can.getConstituency();
            return View(can);
        }
        public ActionResult complaint(Candidate can)
        {
            can.NIC_No = (decimal)Session["NIC"]; //generating candidates and its details
            can.getConstituency();
            return View(can);
        }
        public ActionResult partyStandings()
        {
            return View();
        }

    }
}