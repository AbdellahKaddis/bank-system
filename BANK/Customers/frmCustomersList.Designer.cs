namespace BANK.Customers
{
    partial class frmCustomersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersList));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNumberOfCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cmCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpOpenDateFilter = new System.Windows.Forms.DateTimePicker();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.cmCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1415, 691);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 47);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumberOfCustomers
            // 
            this.lblNumberOfCustomers.AutoSize = true;
            this.lblNumberOfCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCustomers.Location = new System.Drawing.Point(311, 688);
            this.lblNumberOfCustomers.Name = "lblNumberOfCustomers";
            this.lblNumberOfCustomers.Size = new System.Drawing.Size(26, 29);
            this.lblNumberOfCustomers.TabIndex = 41;
            this.lblNumberOfCustomers.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Number Of Customers :";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(147, 93);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(260, 39);
            this.cbFilter.TabIndex = 39;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Filter By :";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(413, 93);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(264, 38);
            this.txtFilterValue.TabIndex = 38;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(539, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 69);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Customers List";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.ContextMenuStrip = this.cmCustomers;
            this.dgvCustomers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCustomers.Location = new System.Drawing.Point(18, 138);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1516, 547);
            this.dgvCustomers.TabIndex = 35;
            // 
            // cmCustomers
            // 
            this.cmCustomers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerInformationToolStripMenuItem,
            this.showAccountInformationToolStripMenuItem,
            this.editCustomerInformationToolStripMenuItem});
            this.cmCustomers.Name = "cmCustomers";
            this.cmCustomers.Size = new System.Drawing.Size(268, 82);
            // 
            // showCustomerInformationToolStripMenuItem
            // 
            this.showCustomerInformationToolStripMenuItem.Image = global::BANK.Properties.Resources.profile;
            this.showCustomerInformationToolStripMenuItem.Name = "showCustomerInformationToolStripMenuItem";
            this.showCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.showCustomerInformationToolStripMenuItem.Text = "Show Customer Information";
            this.showCustomerInformationToolStripMenuItem.Click += new System.EventHandler(this.showCustomerInformationToolStripMenuItem_Click);
            // 
            // showAccountInformationToolStripMenuItem
            // 
            this.showAccountInformationToolStripMenuItem.Image = global::BANK.Properties.Resources.bank_account__2_;
            this.showAccountInformationToolStripMenuItem.Name = "showAccountInformationToolStripMenuItem";
            this.showAccountInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.showAccountInformationToolStripMenuItem.Text = "Show Account Information";
            this.showAccountInformationToolStripMenuItem.Click += new System.EventHandler(this.showAccountInformationToolStripMenuItem_Click);
            // 
            // editCustomerInformationToolStripMenuItem
            // 
            this.editCustomerInformationToolStripMenuItem.Image = global::BANK.Properties.Resources.pencil;
            this.editCustomerInformationToolStripMenuItem.Name = "editCustomerInformationToolStripMenuItem";
            this.editCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.editCustomerInformationToolStripMenuItem.Text = "Edit Customer Information";
            this.editCustomerInformationToolStripMenuItem.Click += new System.EventHandler(this.editCustomerInformationToolStripMenuItem_Click);
            // 
            // dtpOpenDateFilter
            // 
            this.dtpOpenDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOpenDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpenDateFilter.Location = new System.Drawing.Point(413, 94);
            this.dtpOpenDateFilter.Name = "dtpOpenDateFilter";
            this.dtpOpenDateFilter.Size = new System.Drawing.Size(188, 38);
            this.dtpOpenDateFilter.TabIndex = 43;
            this.dtpOpenDateFilter.ValueChanged += new System.EventHandler(this.dtpOpenDateFilter_ValueChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Closed"});
            this.cbIsActive.Location = new System.Drawing.Point(413, 92);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(139, 39);
            this.cbIsActive.TabIndex = 44;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1549, 742);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.dtpOpenDateFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers List Screen";
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.cmCustomers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNumberOfCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DateTimePicker dtpOpenDateFilter;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmCustomers;
        private System.Windows.Forms.ToolStripMenuItem showCustomerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAccountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerInformationToolStripMenuItem;
    }
}