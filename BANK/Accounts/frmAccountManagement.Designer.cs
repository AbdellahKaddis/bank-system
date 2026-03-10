namespace BANK.Accounts
{
    partial class frmAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmAccounts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.activeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccuntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfAccounts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.dtpOpenDateFilter = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.cmAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1050, 700);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 47);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(158, 203);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(260, 39);
            this.cbFilter.TabIndex = 31;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(424, 203);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(264, 38);
            this.txtFilterValue.TabIndex = 30;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(351, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 69);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Account Management";
            // 
            // cmAccounts
            // 
            this.cmAccounts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.fToolStripMenuItem1,
            this.deleteAccountStatusToolStripMenuItem,
            this.toolStripSeparator1,
            this.activeAccountToolStripMenuItem,
            this.closeAccuntToolStripMenuItem});
            this.cmAccounts.Name = "cmAccounts";
            this.cmAccounts.Size = new System.Drawing.Size(259, 140);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Image = global::BANK.Properties.Resources.profile;
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.fToolStripMenuItem.Text = "Show Account Information";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem1
            // 
            this.fToolStripMenuItem1.Image = global::BANK.Properties.Resources.bank_account__1_;
            this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
            this.fToolStripMenuItem1.Size = new System.Drawing.Size(258, 26);
            this.fToolStripMenuItem1.Text = "Add New Account";
            this.fToolStripMenuItem1.Click += new System.EventHandler(this.fToolStripMenuItem1_Click);
            // 
            // deleteAccountStatusToolStripMenuItem
            // 
            this.deleteAccountStatusToolStripMenuItem.Image = global::BANK.Properties.Resources.deleteicon;
            this.deleteAccountStatusToolStripMenuItem.Name = "deleteAccountStatusToolStripMenuItem";
            this.deleteAccountStatusToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.deleteAccountStatusToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountStatusToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountStatusToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // activeAccountToolStripMenuItem
            // 
            this.activeAccountToolStripMenuItem.Image = global::BANK.Properties.Resources.activities;
            this.activeAccountToolStripMenuItem.Name = "activeAccountToolStripMenuItem";
            this.activeAccountToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.activeAccountToolStripMenuItem.Text = "Active Account";
            this.activeAccountToolStripMenuItem.Click += new System.EventHandler(this.activeAccountToolStripMenuItem_Click);
            // 
            // closeAccuntToolStripMenuItem
            // 
            this.closeAccuntToolStripMenuItem.Image = global::BANK.Properties.Resources.close;
            this.closeAccuntToolStripMenuItem.Name = "closeAccuntToolStripMenuItem";
            this.closeAccuntToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.closeAccuntToolStripMenuItem.Text = "Close Accunt";
            this.closeAccuntToolStripMenuItem.Click += new System.EventHandler(this.closeAccuntToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Filter By :";
            // 
            // lblNumberOfAccounts
            // 
            this.lblNumberOfAccounts.AutoSize = true;
            this.lblNumberOfAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAccounts.Location = new System.Drawing.Point(289, 711);
            this.lblNumberOfAccounts.Name = "lblNumberOfAccounts";
            this.lblNumberOfAccounts.Size = new System.Drawing.Size(26, 29);
            this.lblNumberOfAccounts.TabIndex = 35;
            this.lblNumberOfAccounts.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 711);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Number Of Accounts:";
            // 
            // cbIsActive
            // 
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Closed"});
            this.cbIsActive.Location = new System.Drawing.Point(424, 203);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(139, 39);
            this.cbIsActive.TabIndex = 37;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // dtpOpenDateFilter
            // 
            this.dtpOpenDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOpenDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpenDateFilter.Location = new System.Drawing.Point(424, 204);
            this.dtpOpenDateFilter.Name = "dtpOpenDateFilter";
            this.dtpOpenDateFilter.Size = new System.Drawing.Size(188, 38);
            this.dtpOpenDateFilter.TabIndex = 38;
            this.dtpOpenDateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.BackColor = System.Drawing.Color.Navy;
            this.btnAddNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewAccount.Image = global::BANK.Properties.Resources.bank_account__2_;
            this.btnAddNewAccount.Location = new System.Drawing.Point(1041, 157);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(128, 85);
            this.btnAddNewAccount.TabIndex = 29;
            this.btnAddNewAccount.UseVisualStyleBackColor = false;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.ContextMenuStrip = this.cmAccounts;
            this.dgvAccounts.Location = new System.Drawing.Point(17, 248);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.Size = new System.Drawing.Size(1152, 445);
            this.dgvAccounts.TabIndex = 39;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1189, 759);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.dtpOpenDateFilter);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.lblNumberOfAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Management Screen";
            this.Load += new System.EventHandler(this.frmAccountManagement_Load);
            this.cmAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmAccounts;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountStatusToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.DateTimePicker dtpOpenDateFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem activeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccuntToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAccounts;
    }
}