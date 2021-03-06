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
    public partial class frm_Login : Form
    {
        static string strUsername = "";
        static string strPassword = "";
        public frm_Login()
        {
            InitializeComponent();
        }
        Database db;
        private void frm_Login_Load(object sender, EventArgs e)
        {
            db = new Database();
            tb_username.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            strUsername = tb_username.Text;
            strPassword = tb_passsword.Text;
              if (Validation.isValidUser(strUsername, strPassword))
              {
                  this.Hide();
                  frm_Main main = new frm_Main(strUsername);
                  main.Show();
              }
              else {
                  tb_passsword.Text = "";
                  tb_username.Text = "";
                  MessageBox.Show("Username or Password is invalid!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
              }
        }
    }
}
