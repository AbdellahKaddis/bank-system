namespace BANK
{
    partial class frmAdd_Update_User
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_Update_User));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrFindPerson1 = new BANK.ctrFindPerson();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnfront = new System.Windows.Forms.Button();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.tpPermissions = new System.Windows.Forms.TabPage();
            this.chkFullAccess = new System.Windows.Forms.CheckBox();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlPermissions = new System.Windows.Forms.Panel();
            this.chkAccessToManageAccounts = new System.Windows.Forms.CheckBox();
            this.chkAccessToMangePeople = new System.Windows.Forms.CheckBox();
            this.chkAccessToPerformTransactions = new System.Windows.Forms.CheckBox();
            this.chkAccessToManageCustomers = new System.Windows.Forms.CheckBox();
            this.chkAccessToMangeUsers = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabcontrol1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            this.tpPermissions.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(318, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 69);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tbPersonInfo);
            this.tabcontrol1.Controls.Add(this.tpLoginInfo);
            this.tabcontrol1.Controls.Add(this.tpPermissions);
            this.tabcontrol1.Location = new System.Drawing.Point(12, 139);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(911, 644);
            this.tabcontrol1.TabIndex = 2;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.BackColor = System.Drawing.Color.Navy;
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Controls.Add(this.ctrFindPerson1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(903, 615);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(807, 566);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 34);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.BackColor = System.Drawing.Color.Navy;
            this.ctrFindPerson1.EnabledFilterBox = true;
            this.ctrFindPerson1.Location = new System.Drawing.Point(6, 18);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.SerchField = "";
            this.ctrFindPerson1.Size = new System.Drawing.Size(894, 542);
            this.ctrFindPerson1.TabIndex = 0;
            this.ctrFindPerson1.OnPersonSelected += new System.Action<int>(this.ctrFindPerson1_OnPersonSelected);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.Navy;
            this.tpLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpLoginInfo.Controls.Add(this.btnPrevious);
            this.tpLoginInfo.Controls.Add(this.btnfront);
            this.tpLoginInfo.Controls.Add(this.pnlLoginInfo);
            this.tpLoginInfo.ForeColor = System.Drawing.Color.Black;
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(903, 615);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(695, 540);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 34);
            this.btnPrevious.TabIndex = 26;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnfront
            // 
            this.btnfront.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfront.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfront.Location = new System.Drawing.Point(817, 540);
            this.btnfront.Name = "btnfront";
            this.btnfront.Size = new System.Drawing.Size(78, 34);
            this.btnfront.TabIndex = 25;
            this.btnfront.Text = "Next";
            this.btnfront.UseVisualStyleBackColor = true;
            this.btnfront.Click += new System.EventHandler(this.btnfront_Click);
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.Controls.Add(this.label4);
            this.pnlLoginInfo.Controls.Add(this.lblUserId);
            this.pnlLoginInfo.Controls.Add(this.chkIsActive);
            this.pnlLoginInfo.Controls.Add(this.txtUserName);
            this.pnlLoginInfo.Controls.Add(this.label1);
            this.pnlLoginInfo.Controls.Add(this.txtPassword);
            this.pnlLoginInfo.Controls.Add(this.label3);
            this.pnlLoginInfo.Controls.Add(this.label2);
            this.pnlLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.pnlLoginInfo.Location = new System.Drawing.Point(112, 65);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(343, 412);
            this.pnlLoginInfo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "User ID : ";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(162, 15);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(26, 29);
            this.lblUserId.TabIndex = 12;
            this.lblUserId.Text = "?";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(28, 368);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(132, 33);
            this.chkIsActive.TabIndex = 13;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(28, 101);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(253, 38);
            this.txtUserName.TabIndex = 6;
    
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(28, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(253, 38);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Location = new System.Drawing.Point(28, 295);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(253, 38);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // tpPermissions
            // 
            this.tpPermissions.BackColor = System.Drawing.Color.Navy;
            this.tpPermissions.Controls.Add(this.chkFullAccess);
            this.tpPermissions.Controls.Add(this.btnback);
            this.tpPermissions.Controls.Add(this.pnlPermissions);
            this.tpPermissions.Location = new System.Drawing.Point(4, 25);
            this.tpPermissions.Name = "tpPermissions";
            this.tpPermissions.Size = new System.Drawing.Size(903, 615);
            this.tpPermissions.TabIndex = 2;
            this.tpPermissions.Text = "Permissions";
            // 
            // chkFullAccess
            // 
            this.chkFullAccess.AutoSize = true;
            this.chkFullAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFullAccess.Location = new System.Drawing.Point(184, 90);
            this.chkFullAccess.Name = "chkFullAccess";
            this.chkFullAccess.Size = new System.Drawing.Size(167, 33);
            this.chkFullAccess.TabIndex = 28;
            this.chkFullAccess.Text = "Full access";
            this.chkFullAccess.UseVisualStyleBackColor = true;
            this.chkFullAccess.CheckedChanged += new System.EventHandler(this.chkFullAccess_CheckedChanged);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(762, 544);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 34);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "Previous";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.Controls.Add(this.chkAccessToManageAccounts);
            this.pnlPermissions.Controls.Add(this.chkAccessToMangePeople);
            this.pnlPermissions.Controls.Add(this.chkAccessToPerformTransactions);
            this.pnlPermissions.Controls.Add(this.chkAccessToManageCustomers);
            this.pnlPermissions.Controls.Add(this.chkAccessToMangeUsers);
            this.pnlPermissions.Location = new System.Drawing.Point(181, 129);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(408, 249);
            this.pnlPermissions.TabIndex = 27;
            // 
            // chkAccessToManageAccounts
            // 
            this.chkAccessToManageAccounts.AutoSize = true;
            this.chkAccessToManageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccessToManageAccounts.Location = new System.Drawing.Point(3, 3);
            this.chkAccessToManageAccounts.Name = "chkAccessToManageAccounts";
            this.chkAccessToManageAccounts.Size = new System.Drawing.Size(357, 33);
            this.chkAccessToManageAccounts.TabIndex = 25;
            this.chkAccessToManageAccounts.Text = "Access to manage accounts";
            this.chkAccessToManageAccounts.UseVisualStyleBackColor = true;
            this.chkAccessToManageAccounts.CheckedChanged += new System.EventHandler(this.DisabledChkWhenOtherChkIsChecked);
            // 
            // chkAccessToMangePeople
            // 
            this.chkAccessToMangePeople.AutoSize = true;
            this.chkAccessToMangePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccessToMangePeople.Location = new System.Drawing.Point(3, 84);
            this.chkAccessToMangePeople.Name = "chkAccessToMangePeople";
            this.chkAccessToMangePeople.Size = new System.Drawing.Size(336, 33);
            this.chkAccessToMangePeople.TabIndex = 18;
            this.chkAccessToMangePeople.Text = "Access to manage people";
            this.chkAccessToMangePeople.UseVisualStyleBackColor = true;
            this.chkAccessToMangePeople.CheckedChanged += new System.EventHandler(this.DisabledChkWhenOtherChkIsChecked);
            // 
            // chkAccessToPerformTransactions
            // 
            this.chkAccessToPerformTransactions.AutoSize = true;
            this.chkAccessToPerformTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccessToPerformTransactions.Location = new System.Drawing.Point(3, 168);
            this.chkAccessToPerformTransactions.Name = "chkAccessToPerformTransactions";
            this.chkAccessToPerformTransactions.Size = new System.Drawing.Size(392, 33);
            this.chkAccessToPerformTransactions.TabIndex = 22;
            this.chkAccessToPerformTransactions.Text = "Access to perform transactions";
            this.chkAccessToPerformTransactions.UseVisualStyleBackColor = true;
            this.chkAccessToPerformTransactions.CheckedChanged += new System.EventHandler(this.DisabledChkWhenOtherChkIsChecked);
            // 
            // chkAccessToManageCustomers
            // 
            this.chkAccessToManageCustomers.AutoSize = true;
            this.chkAccessToManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccessToManageCustomers.Location = new System.Drawing.Point(3, 45);
            this.chkAccessToManageCustomers.Name = "chkAccessToManageCustomers";
            this.chkAccessToManageCustomers.Size = new System.Drawing.Size(374, 33);
            this.chkAccessToManageCustomers.TabIndex = 24;
            this.chkAccessToManageCustomers.Text = "Access to manage customers";
            this.chkAccessToManageCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAccessToManageCustomers.UseVisualStyleBackColor = true;
            this.chkAccessToManageCustomers.CheckedChanged += new System.EventHandler(this.DisabledChkWhenOtherChkIsChecked);
            // 
            // chkAccessToMangeUsers
            // 
            this.chkAccessToMangeUsers.AutoSize = true;
            this.chkAccessToMangeUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccessToMangeUsers.Location = new System.Drawing.Point(3, 126);
            this.chkAccessToMangeUsers.Name = "chkAccessToMangeUsers";
            this.chkAccessToMangeUsers.Size = new System.Drawing.Size(304, 33);
            this.chkAccessToMangeUsers.TabIndex = 23;
            this.chkAccessToMangeUsers.Text = "Access to mange users";
            this.chkAccessToMangeUsers.UseVisualStyleBackColor = true;
            this.chkAccessToMangeUsers.CheckedChanged += new System.EventHandler(this.DisabledChkWhenOtherChkIsChecked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(679, 789);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 47);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(804, 789);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 47);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdd_Update_User
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(944, 952);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd_Update_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdd_Update_User";
            this.Load += new System.EventHandler(this.frmAdd_Update_User_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            this.tpPermissions.ResumeLayout(false);
            this.tpPermissions.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private ctrFindPerson ctrFindPerson1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tpPermissions;
        private System.Windows.Forms.Panel pnlPermissions;
        private System.Windows.Forms.CheckBox chkAccessToManageAccounts;
        private System.Windows.Forms.CheckBox chkAccessToMangePeople;
        private System.Windows.Forms.CheckBox chkAccessToPerformTransactions;
        private System.Windows.Forms.CheckBox chkAccessToManageCustomers;
        private System.Windows.Forms.CheckBox chkAccessToMangeUsers;
        private System.Windows.Forms.CheckBox chkFullAccess;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnfront;
        private System.Windows.Forms.Button btnback;
    }
}