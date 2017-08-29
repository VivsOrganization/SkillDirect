using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1RDLC.Models;

namespace _1RDLC.Controllers
{
    public class HomeController : Controller
    {
        SkillDbEntities sdEnt = new SkillDbEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<tblEmp> tblEmpList = sdEnt.tblEmps.ToList();
            return View(tblEmpList);
        }

        public ActionResult Report()
        {
            return Redirect("~/Report/WebForm1.aspx");
        }
    }
}