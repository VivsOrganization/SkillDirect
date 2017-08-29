using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _1RDLC.Models;

namespace _1RDLC.Report
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SkillDbEntities SDEnt = new SkillDbEntities();            
                List<tblEmp> Emp = SDEnt.tblEmps.ToList();
                //ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/Report1.rdlc");
                ReportViewer2.LocalReport.DataSources.Clear();
                ReportDataSource RDS = new ReportDataSource("DataSet1", Emp);
                ReportViewer2.LocalReport.DataSources.Add(RDS);
                ReportViewer2.LocalReport.Refresh();
            }

        }
    }
}