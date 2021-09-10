using System;
using System.Configuration;
using System.IO;
using System.Web.Script.Serialization;
using System.Web.UI; 
using Stimulsoft.Report;
using Stimulsoft.Report.Web;

namespace SSG.DataService.WebApi
{
    public partial class DashboardViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHlXBRYpqIu85TJee0cULcitGVcNYDPQMwCkGcjGnpvX9W+7tR" +
                                                 "80UHi9GCFIH94dsSfEQS4qeHtYK4GNp43KMq2/K1RJ0mz8wa9bAteA95iTSusD/43otwrXekvwDUNtgFN1QqHMF3kM" +
                                                 "dJFYO9o/KyK+ZYW78dKRz1V1fCzjt+5XhcY/r3YbgKEvuGUPCJG6Bj3g0yiWnC86CLI1JJJ2Ns44d+yl1AVpERFnqa" +
                                                 "iOgBK43J2kyI48yn+h4bXqKCujPD8mjV2RqNYwJ5JSVveXELP+RCf69/1XBwnqi0T7Ln87j4Hm6vAsyUP0/Dyw+xEK" +
                                                 "evGg41VDdvtnarJrpSWtmlZ40H1oDoKh1bzkC5y6HP2vQ//NDk8cQsgK+KAiVrMc7XeiLBhMvtYa68ZUAnZhwlgPan" +
                                                 "z+i7TJcK1GfjmXuFdN3ys8XlJ8z/Wt+Ukrx8EV3r5UQ0cowM4UaXur2+aS1RH1CG6vrFDUvMUtW+tA/UP8PWyJXeeh" +
                                                 "Sl274v0YyzPTv76jWMf2znf/bS9itCdFXE39";
            }
            catch (Exception ex1)
            {
                Page.Controls.Add(new LiteralControl("DashboardViewer.aspx Page_Load : Ex1 = " + ex1));
                System.Diagnostics.Debug.WriteLine("DashboardViewer.aspx Page_Load : Ex1 = " + ex1);
            }
        }
        protected void StiWebViewer1_OnGetReport(object sender, StiReportDataEventArgs e)
        {
            StiReport report = StiReport.CreateNewDashboard();
            try
            {
                Request.ContentEncoding = System.Text.Encoding.UTF8;

                string filePath = ConfigurationManager.AppSettings["FilePath"]; ;
                if (File.Exists(filePath))
                {
                    //loading report file
                    report.Load(filePath);
                }
            }
            catch (Exception ex1)
            {
                Page.Controls.Add(new LiteralControl("DashboardViewer.aspx Page_Load : Ex1 = " + ex1));
                System.Diagnostics.Debug.WriteLine("DashboardViewer.aspx Page_Load : Ex1 = " + ex1);
            }
            e.Report = report;
        }
    }
}