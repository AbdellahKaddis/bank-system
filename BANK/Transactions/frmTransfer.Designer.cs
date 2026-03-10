namespace BANK.Transactions
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFindAccount = new System.Windows.Forms.TabPage();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAccount1 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpFindAccount2 = new System.Windows.Forms.TabPage();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSerachForAccount2 = new System.Windows.Forms.Button();
            this.lblAccount2 = new System.Windows.Forms.Label();
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCfullname = new System.Windows.Forms.Label();
            this.lblSts = new System.Windows.Forms.Label();
            this.lblAccountT = new System.Windows.Forms.Label();
            this.lblODate = new System.Windows.Forms.Label();
            this.lblAccountN = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tpTransfer = new System.Windows.Forms.TabPage();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpFindAccount.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpFindAccount2.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpTransfer.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(374, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 69);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Transfer ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFindAccount);
            this.tabControl1.Controls.Add(this.tpFindAccount2);
            this.tabControl1.Controls.Add(this.tpTransfer);
            this.tabControl1.Location = new System.Drawing.Point(26, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 618);
            this.tabControl1.TabIndex = 25;
            // 
            // tpFindAccount
            // 
            this.tpFindAccount.BackColor = System.Drawing.Color.Navy;
            this.tpFindAccount.Controls.Add(this.gbFilter);
            this.tpFindAccount.Controls.Add(this.groupBox1);
            this.tpFindAccount.Location = new System.Drawing.Point(4, 25);
            this.tpFindAccount.Name = "tpFindAccount";
            this.tpFindAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpFindAccount.Size = new System.Drawing.Size(941, 589);
            this.tpFindAccount.TabIndex = 0;
            this.tpFindAccount.Text = "Find Account";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.lblAccount1);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Location = new System.Drawing.Point(40, 43);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(867, 82);
            this.gbFilter.TabIndex = 27;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = global::BANK.Properties.Resources.search__1_;
            this.btnSearch.Location = new System.Drawing.Point(664, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAccount1
            // 
            this.lblAccount1.AutoSize = true;
            this.lblAccount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount1.Location = new System.Drawing.Point(29, 31);
            this.lblAccount1.Name = "lblAccount1";
            this.lblAccount1.Size = new System.Drawing.Size(187, 29);
            this.lblAccount1.TabIndex = 26;
            this.lblAccount1.Text = "From Account :";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(262, 26);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(396, 38);
            this.txtFilterValue.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblCustomerFullName);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.lblOpenDate);
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 419);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(384, 351);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(25, 29);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "?";
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFullName.Location = new System.Drawing.Point(384, 292);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(25, 29);
            this.lblCustomerFullName.TabIndex = 14;
            this.lblCustomerFullName.Text = "?";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(384, 228);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(25, 29);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "?";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(384, 115);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(25, 29);
            this.lblAccountType.TabIndex = 12;
            this.lblAccountType.Text = "?";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(384, 171);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(25, 29);
            this.lblOpenDate.TabIndex = 11;
            this.lblOpenDate.Text = "?";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(384, 54);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(25, 29);
            this.lblAccountNumber.TabIndex = 10;
            this.lblAccountNumber.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Balance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer  FullName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Open Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Number :";
            // 
            // tpFindAccount2
            // 
            this.tpFindAccount2.BackColor = System.Drawing.Color.Navy;
            this.tpFindAccount2.Controls.Add(this.gbSearch);
            this.tpFindAccount2.Controls.Add(this.groupBox3);
            this.tpFindAccount2.Location = new System.Drawing.Point(4, 25);
            this.tpFindAccount2.Name = "tpFindAccount2";
            this.tpFindAccount2.Padding = new System.Windows.Forms.Padding(3);
            this.tpFindAccount2.Size = new System.Drawing.Size(941, 589);
            this.tpFindAccount2.TabIndex = 1;
            this.tpFindAccount2.Text = "Find Account 2";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSerachForAccount2);
            this.gbSearch.Controls.Add(this.lblAccount2);
            this.gbSearch.Controls.Add(this.txtSearchField);
            this.gbSearch.Location = new System.Drawing.Point(37, 41);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(867, 82);
            this.gbSearch.TabIndex = 29;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Filter";
            // 
            // btnSerachForAccount2
            // 
            this.btnSerachForAccount2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSerachForAccount2.Image = global::BANK.Properties.Resources.search__1_;
            this.btnSerachForAccount2.Location = new System.Drawing.Point(631, 26);
            this.btnSerachForAccount2.Name = "btnSerachForAccount2";
            this.btnSerachForAccount2.Size = new System.Drawing.Size(50, 39);
            this.btnSerachForAccount2.TabIndex = 1;
            this.btnSerachForAccount2.UseVisualStyleBackColor = true;
            this.btnSerachForAccount2.Click += new System.EventHandler(this.btnSerachForAccount2_Click);
            // 
            // lblAccount2
            // 
            this.lblAccount2.AutoSize = true;
            this.lblAccount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount2.Location = new System.Drawing.Point(29, 31);
            this.lblAccount2.Name = "lblAccount2";
            this.lblAccount2.Size = new System.Drawing.Size(158, 29);
            this.lblAccount2.TabIndex = 26;
            this.lblAccount2.Text = "To Account :";
            // 
            // txtSearchField
            // 
            this.txtSearchField.BackColor = System.Drawing.Color.White;
            this.txtSearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchField.ForeColor = System.Drawing.Color.Black;
            this.txtSearchField.Location = new System.Drawing.Point(229, 26);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(396, 38);
            this.txtSearchField.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAmount);
            this.groupBox3.Controls.Add(this.lblCfullname);
            this.groupBox3.Controls.Add(this.lblSts);
            this.groupBox3.Controls.Add(this.lblAccountT);
            this.groupBox3.Controls.Add(this.lblODate);
            this.groupBox3.Controls.Add(this.lblAccountN);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(37, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 419);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Information";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(384, 351);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(25, 29);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "?";
            // 
            // lblCfullname
            // 
            this.lblCfullname.AutoSize = true;
            this.lblCfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfullname.Location = new System.Drawing.Point(384, 292);
            this.lblCfullname.Name = "lblCfullname";
            this.lblCfullname.Size = new System.Drawing.Size(25, 29);
            this.lblCfullname.TabIndex = 14;
            this.lblCfullname.Text = "?";
            // 
            // lblSts
            // 
            this.lblSts.AutoSize = true;
            this.lblSts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSts.Location = new System.Drawing.Point(384, 228);
            this.lblSts.Name = "lblSts";
            this.lblSts.Size = new System.Drawing.Size(25, 29);
            this.lblSts.TabIndex = 13;
            this.lblSts.Text = "?";
            // 
            // lblAccountT
            // 
            this.lblAccountT.AutoSize = true;
            this.lblAccountT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountT.Location = new System.Drawing.Point(384, 115);
            this.lblAccountT.Name = "lblAccountT";
            this.lblAccountT.Size = new System.Drawing.Size(25, 29);
            this.lblAccountT.TabIndex = 12;
            this.lblAccountT.Text = "?";
            // 
            // lblODate
            // 
            this.lblODate.AutoSize = true;
            this.lblODate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODate.Location = new System.Drawing.Point(384, 171);
            this.lblODate.Name = "lblODate";
            this.lblODate.Size = new System.Drawing.Size(25, 29);
            this.lblODate.TabIndex = 11;
            this.lblODate.Text = "?";
            // 
            // lblAccountN
            // 
            this.lblAccountN.AutoSize = true;
            this.lblAccountN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountN.Location = new System.Drawing.Point(384, 54);
            this.lblAccountN.Name = "lblAccountN";
            this.lblAccountN.Size = new System.Drawing.Size(25, 29);
            this.lblAccountN.TabIndex = 10;
            this.lblAccountN.Text = "?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(224, 351);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 29);
            this.label16.TabIndex = 9;
            this.label16.Text = "Balance :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(79, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(266, 29);
            this.label17.TabIndex = 8;
            this.label17.Text = "Customer  FullName :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(246, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 29);
            this.label18.TabIndex = 7;
            this.label18.Text = "Status :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(193, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 29);
            this.label19.TabIndex = 6;
            this.label19.Text = "Open Date :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(160, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(185, 29);
            this.label20.TabIndex = 5;
            this.label20.Text = "Account Type :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(126, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(219, 29);
            this.label21.TabIndex = 4;
            this.label21.Text = "Account Number :";
            // 
            // tpTransfer
            // 
            this.tpTransfer.BackColor = System.Drawing.Color.Navy;
            this.tpTransfer.Controls.Add(this.pnlTransaction);
            this.tpTransfer.Location = new System.Drawing.Point(4, 25);
            this.tpTransfer.Name = "tpTransfer";
            this.tpTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransfer.Size = new System.Drawing.Size(941, 589);
            this.tpTransfer.TabIndex = 2;
            this.tpTransfer.Text = "Transfer";
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.Controls.Add(this.lblQuestion);
            this.pnlTransaction.Controls.Add(this.btnTransfer);
            this.pnlTransaction.Controls.Add(this.txtBalance);
            this.pnlTransaction.Location = new System.Drawing.Point(193, 190);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(555, 208);
            this.pnlTransaction.TabIndex = 26;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(27, 32);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(489, 29);
            this.lblQuestion.TabIndex = 23;
            this.lblQuestion.Text = "Enter how much do you want to transfer ?";
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(32, 137);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(170, 47);
            this.btnTransfer.TabIndex = 22;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Location = new System.Drawing.Point(32, 73);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(231, 38);
            this.txtBalance.TabIndex = 24;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            this.txtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.txtBalance_Validating);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(856, 732);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 47);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1014, 799);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Screen";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpFindAccount.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpFindAccount2.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpTransfer.ResumeLayout(false);
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFindAccount;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAccount1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpFindAccount2;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSerachForAccount2;
        private System.Windows.Forms.Label lblAccount2;
        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCfullname;
        private System.Windows.Forms.Label lblSts;
        private System.Windows.Forms.Label lblAccountT;
        private System.Windows.Forms.Label lblODate;
        private System.Windows.Forms.Label lblAccountN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tpTransfer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}