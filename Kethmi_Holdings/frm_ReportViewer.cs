﻿using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;

namespace Kethmi_Holdings
{
    public partial class frm_ReportViewer : Form
    {
        public frm_ReportViewer()
        {
            InitializeComponent();
        }

        private void frm_ReportViewer_Load(object sender, EventArgs e)
        {
            string strServer = ConfigurationManager.AppSettings["Server"].ToString();

           ConnectionInfo crConnection = new ConnectionInfo();
           crConnection.UserID = "smgsystems";
            crConnection.ServerName = strServer;
            crConnection.DatabaseName = "KethmiHoldings";
            crConnection.Password = "smgsoft";

            ReportDocument myRpt = new ReportDocument();
            myRpt.Load(Application.StartupPath + "\\Reports\\Reciept.rpt");

            AssignConnectionInfo(myRpt, crConnection);
            myRpt.SetDatabaseLogon(crConnection.UserID, crConnection.Password, strServer, crConnection.DatabaseName);
            crystalReportViewer1.ReportSource = myRpt;
       
          //  crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();
        }
        private void AssignConnectionInfo(ReportDocument document, ConnectionInfo crConnection)
        {
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in document.Database.Tables)
            {
                TableLogOnInfo logOnInfo = table.LogOnInfo;
                if (logOnInfo != null)
                {
                    table.ApplyLogOnInfo(table.LogOnInfo);
                    table.LogOnInfo.TableName = table.Name;
                    table.LogOnInfo.ConnectionInfo.UserID = crConnection.UserID;
                    table.LogOnInfo.ConnectionInfo.Password = crConnection.Password;
                    table.LogOnInfo.ConnectionInfo.DatabaseName = crConnection.DatabaseName;
                    table.LogOnInfo.ConnectionInfo.ServerName = crConnection.ServerName;
                }
            }
        }
    }
}