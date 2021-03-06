﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kethmi_Holdings
{
    public partial class frm_Main : Form
    {
        frm_Project frmProject;
        frm_Advertising frmAdvertising;
        frm_Customers frmCustomers;
        frm_Reports frmReports;
        frm_Sales frmSales;
        frm_Recipts frmRecipts;
        RptProjects rptProjects;
        RptCustomerDetails rptCusDetails;
        frm_UserControl frmUserCtrl;
       


        string strUsername = "";
        public frm_Main(string username)
        {
            InitializeComponent();
            strUsername = username;
            tssl_loggedAs.Text = "| Logged as : "+strUsername+" |";
            this.strUsername = username;
        }

        public frm_Main()
        {
            InitializeComponent();            
        }
         

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login f = new frm_Login();
            f.MdiParent = this;
            f.Show();
        }
        
        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnProjects_Click(sender,e);
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            frmProject = new frm_Project(strUsername);
            frmProject.FormClosed += new FormClosedEventHandler(frmProject_FormClosed);
            frmProject.MdiParent = this;
            frmProject.Show();
            btnProjects.Enabled = false;
            ts_side.Visible = true;
        }
        

        private void frmProject_FormClosed(object sender, EventArgs e) {
            btnProjects.Enabled = true;
            
            CommonClass.setToolTipButtonStates(false);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales = new frm_Sales();
            frmSales.FormClosed += new FormClosedEventHandler(frmSales_FormClosed);
            frmSales.MdiParent = this;
            frmSales.Show();
            CommonClass.setToolTipButtonStates(false);
            btnSales.Enabled = false;
            ts_side.Visible = true;
        }
        private void frmSales_FormClosed(object sender, EventArgs e) {
            btnSales.Enabled = true;
            CommonClass.setToolTipButtonStates(false);
            btnSales.Enabled = true;
        }

        private void btnAdvertising_Click(object sender, EventArgs e)
        {
            frmAdvertising = new frm_Advertising();
            frmAdvertising.FormClosed += new FormClosedEventHandler(frmAdvertising_FormClosed);
            frmAdvertising.MdiParent = this;
            frmAdvertising.Show();
            btnAdvertising.Enabled = false;
            ts_side.Visible = true;
        }
        private void frmAdvertising_FormClosed(object sender, EventArgs e)
        {
            btnAdvertising.Enabled = true;
        }

        private void btnReciepts_Click(object sender, EventArgs e)
        {
            frmRecipts = new frm_Recipts(strUsername);
            frmRecipts.FormClosed += new FormClosedEventHandler(frmRecipts_FormClosed);
            frmRecipts.MdiParent = this;
            frmRecipts.Show();
            CommonClass.setToolTipButtonStates(true,true,false,true,false,false);
            btnReciepts.Enabled = false;
            ts_side.Visible = true;
        }

        private void frmRecipts_FormClosed(object sender, EventArgs e)
        {
            btnReciepts.Enabled = true;
            CommonClass.setToolTipButtonStates(false);

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers = new frm_Customers(strUsername);
            frmCustomers.FormClosed += new FormClosedEventHandler(frmCustomers_FormClosed);
            frmCustomers.MdiParent = this;
            frmCustomers.Show();
            btnCustomers.Enabled = false;
            ts_side.Visible = true;
        }

        private void frmCustomers_FormClosed(object sender, EventArgs e)
        {
            btnCustomers.Enabled = true;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //set all the side bar buttons into false
            CommonClass.setToolTipButtonStates(false);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == frmProject)
            {
                frmProject.ButtonNew();        
            }
            
            else if (this.ActiveMdiChild == frmUserCtrl)
            {
                frmUserCtrl.ButtonNew();
            }      
            else if(this.ActiveMdiChild == frmCustomers)
            {
                frmCustomers.ButtonNew();
            }   
            else if(this.ActiveMdiChild == frmRecipts)
            {
                frmRecipts.ButtonNew();
            }           
        }

        private void frm_Main_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            ts_side.Visible = false;
            CommonClass.setToolTipButtonStates(false);
        }

        private void ts_main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void projectManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptProjects = new RptProjects();
            rptProjects.MdiParent = this;
            rptProjects.Show();
            ts_side.Visible = true;
        }

        private void customerDetailsSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptCusDetails = new RptCustomerDetails();
            rptCusDetails.MdiParent = this;
            rptCusDetails.Show();
            ts_side.Visible = true;
        }

        private void userControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCtrl = new frm_UserControl(strUsername);
            frmUserCtrl.MdiParent = this;
            frmUserCtrl.FormClosed += new FormClosedEventHandler(frmUserCtrl_FormClosed);
            frmUserCtrl.Show();
          
            userControlToolStripMenuItem.Enabled = false;
            ts_side.Visible = true;

        }
        private void frmUserCtrl_FormClosed(object sender, EventArgs e)
        {
            CommonClass.setToolTipButtonStates(false);
            userControlToolStripMenuItem.Enabled = true;
        }


        private void customerControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers = new frm_Customers(strUsername);
            frmCustomers.MdiParent = this;
            frmCustomers.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null,"Are you sure?", "Confirm Exit !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Environment.Exit(0);
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == frmProject)
            {
                frmProject.ButtonClear();
            }
            else if(this.ActiveMdiChild == frmCustomers)
            {
                frmCustomers.ButtonClear();
            }
            else if(this.ActiveMdiChild == frmRecipts)
            {
                frmRecipts.ButtonClear();
            }
            else if (this.ActiveMdiChild== frmUserCtrl)
            {
                frmUserCtrl.ButtonClear();
            }
            }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == frmUserCtrl)
            {
                frmUserCtrl.ButtonSave();  
            }
            else if (this.ActiveMdiChild == frmProject)
            {
                frmProject.ButtonSave();
            }
            else if(this.ActiveMdiChild == frmCustomers)
            {
                frmCustomers.ButtonSave();
            }
            else if(this.ActiveMdiChild == frmRecipts)
            {
                frmRecipts.ButtonSave();
            }
        }

        public static implicit operator frm_Main(frm_Login v)
        {
            throw new NotImplementedException();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == frmProject)
            {
                frmProject.ButtonDelete();
            }
            else if(this.ActiveMdiChild == frmCustomers)
            {
                frmCustomers.ButtonDelete();
            }
            else if(this.ActiveMdiChild == frmRecipts)
            {
                frmRecipts.ButtonDelete();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == frmProject)
            {
                frmProject.ButtonEdit();
            }
            else if(this.ActiveMdiChild == frmCustomers)
            {
                frmCustomers.ButtonEdit();
            }  
            else if(this.ActiveMdiChild == frmRecipts)
            {
                frmRecipts.ButtonEdit();
            }
            else if (this.ActiveMdiChild == frmUserCtrl)
            {
                frmUserCtrl.ButtonEdit();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == frmRecipts)
            {
                frmRecipts.ButtonPrint();
            }
            else if (this.ActiveMdiChild== rptProjects)
            {
                rptProjects.ButtonPrint();
            }
            else if (this.ActiveMdiChild== rptCusDetails)
            {
                rptCusDetails.ButtonPrint();
            }
        }

        private void aboutSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_About_System().ShowDialog();
        }

        private void tssl_time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssl_time.Text = "Date and Time : "+DateTime.Now.ToString();
        }

        private void paymentTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
