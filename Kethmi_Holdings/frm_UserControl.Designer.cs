﻿namespace Kethmi_Holdings
{
    partial class frm_UserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserControl));
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.rbtAdmin = new System.Windows.Forms.RadioButton();
            this.rbtUser = new System.Windows.Forms.RadioButton();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.gb_inputArea = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.gb_currentUsers = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.gb_inputArea.SuspendLayout();
            this.gb_currentUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewUsers.Location = new System.Drawing.Point(20, 37);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(598, 583);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUsers_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Type";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(36, 308);
            this.chkActive.Margin = new System.Windows.Forms.Padding(6);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(172, 29);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Activate User";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // rbtAdmin
            // 
            this.rbtAdmin.AutoSize = true;
            this.rbtAdmin.Location = new System.Drawing.Point(234, 244);
            this.rbtAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Size = new System.Drawing.Size(103, 29);
            this.rbtAdmin.TabIndex = 7;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.Text = "Admin";
            this.rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtUser
            // 
            this.rbtUser.AutoSize = true;
            this.rbtUser.Checked = true;
            this.rbtUser.Location = new System.Drawing.Point(354, 244);
            this.rbtUser.Margin = new System.Windows.Forms.Padding(6);
            this.rbtUser.Name = "rbtUser";
            this.rbtUser.Size = new System.Drawing.Size(88, 29);
            this.rbtUser.TabIndex = 8;
            this.rbtUser.TabStop = true;
            this.rbtUser.Text = "User";
            this.rbtUser.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(234, 146);
            this.txtPW.Margin = new System.Windows.Forms.Padding(6);
            this.txtPW.MaxLength = 45;
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(342, 31);
            this.txtPW.TabIndex = 9;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(234, 87);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserID.MaxLength = 45;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(342, 31);
            this.txtUserID.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(234, 37);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserName.MaxLength = 45;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(342, 31);
            this.txtUserName.TabIndex = 11;
            // 
            // gb_inputArea
            // 
            this.gb_inputArea.Controls.Add(this.label1);
            this.gb_inputArea.Controls.Add(this.txtConfirm);
            this.gb_inputArea.Controls.Add(this.label3);
            this.gb_inputArea.Controls.Add(this.label2);
            this.gb_inputArea.Controls.Add(this.txtUserName);
            this.gb_inputArea.Controls.Add(this.label4);
            this.gb_inputArea.Controls.Add(this.txtUserID);
            this.gb_inputArea.Controls.Add(this.label5);
            this.gb_inputArea.Controls.Add(this.txtPW);
            this.gb_inputArea.Controls.Add(this.chkActive);
            this.gb_inputArea.Controls.Add(this.rbtUser);
            this.gb_inputArea.Controls.Add(this.rbtAdmin);
            this.gb_inputArea.Location = new System.Drawing.Point(666, 23);
            this.gb_inputArea.Margin = new System.Windows.Forms.Padding(6);
            this.gb_inputArea.Name = "gb_inputArea";
            this.gb_inputArea.Padding = new System.Windows.Forms.Padding(6);
            this.gb_inputArea.Size = new System.Drawing.Size(646, 646);
            this.gb_inputArea.TabIndex = 13;
            this.gb_inputArea.TabStop = false;
            this.gb_inputArea.Text = "Input Area";
            this.gb_inputArea.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirm";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Location = new System.Drawing.Point(234, 196);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirm.MaxLength = 45;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(342, 31);
            this.txtConfirm.TabIndex = 13;
            // 
            // gb_currentUsers
            // 
            this.gb_currentUsers.Controls.Add(this.dataGridViewUsers);
            this.gb_currentUsers.Location = new System.Drawing.Point(24, 23);
            this.gb_currentUsers.Margin = new System.Windows.Forms.Padding(6);
            this.gb_currentUsers.Name = "gb_currentUsers";
            this.gb_currentUsers.Padding = new System.Windows.Forms.Padding(6);
            this.gb_currentUsers.Size = new System.Drawing.Size(630, 646);
            this.gb_currentUsers.TabIndex = 14;
            this.gb_currentUsers.TabStop = false;
            this.gb_currentUsers.Text = "Current Users";
            // 
            // frm_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 681);
            this.Controls.Add(this.gb_currentUsers);
            this.Controls.Add(this.gb_inputArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(82, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_UserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Control";
            this.Activated += new System.EventHandler(this.frm_UserControl_Activated);
            this.Deactivate += new System.EventHandler(this.frm_UserControl_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_UserControl_FormClosing);
            this.Load += new System.EventHandler(this.frm_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.gb_inputArea.ResumeLayout(false);
            this.gb_inputArea.PerformLayout();
            this.gb_currentUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.RadioButton rbtAdmin;
        private System.Windows.Forms.RadioButton rbtUser;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox gb_inputArea;
        private System.Windows.Forms.GroupBox gb_currentUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}