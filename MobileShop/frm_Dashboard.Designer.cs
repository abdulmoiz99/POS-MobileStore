namespace MobileShop
{
    partial class frm_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.Chart_PurchaseOrder = new DevExpress.XtraCharts.ChartControl();
            this.Chart_SaleOrder = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_PayAmt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_RecAmt = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Type = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_Username = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Expense = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lab_ExpenseTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.pnl_Expense = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnl_Profit = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lab_TodayProfit = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.Lab_TodayPurchase = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Lab_TodaySale = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Lab_TodayReceive = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.Lab_TodayPaid = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lab_date = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_OpeningBalance = new System.Windows.Forms.TextBox();
            this.btn_OpenCounter = new System.Windows.Forms.Button();
            this.DashboardUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_PurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_SaleOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).BeginInit();
            this.panel8.SuspendLayout();
            this.pnl_Expense.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnl_Profit.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart_PurchaseOrder
            // 
            this.Chart_PurchaseOrder.Location = new System.Drawing.Point(16, 429);
            this.Chart_PurchaseOrder.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.Chart_PurchaseOrder.Name = "Chart_PurchaseOrder";
            this.Chart_PurchaseOrder.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.Chart_PurchaseOrder.Size = new System.Drawing.Size(479, 210);
            this.Chart_PurchaseOrder.TabIndex = 0;
            this.Chart_PurchaseOrder.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl1_CustomDrawSeriesPoint);
            // 
            // Chart_SaleOrder
            // 
            this.Chart_SaleOrder.Location = new System.Drawing.Point(498, 429);
            this.Chart_SaleOrder.Name = "Chart_SaleOrder";
            this.Chart_SaleOrder.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.Chart_SaleOrder.Size = new System.Drawing.Size(449, 211);
            this.Chart_SaleOrder.TabIndex = 0;
            this.Chart_SaleOrder.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl1_CustomDrawSeriesPoint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lab_PayAmt);
            this.panel1.Location = new System.Drawing.Point(15, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 112);
            this.panel1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(2, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 32);
            this.label10.TabIndex = 37;
            this.label10.Text = "PKR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(131, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "View Info →";
            // 
            // lab_PayAmt
            // 
            this.lab_PayAmt.AutoSize = true;
            this.lab_PayAmt.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PayAmt.ForeColor = System.Drawing.Color.White;
            this.lab_PayAmt.Location = new System.Drawing.Point(3, 37);
            this.lab_PayAmt.Name = "lab_PayAmt";
            this.lab_PayAmt.Size = new System.Drawing.Size(41, 52);
            this.lab_PayAmt.TabIndex = 13;
            this.lab_PayAmt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "PayAble";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(16, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 35);
            this.panel2.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(14, 405);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 17);
            this.panel6.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(231, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 17);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(231, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 36);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Receivable";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(108)))), ((int)(((byte)(173)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lab_RecAmt);
            this.panel5.Location = new System.Drawing.Point(231, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 112);
            this.panel5.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(2, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 32);
            this.label11.TabIndex = 38;
            this.label11.Text = "PKR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(131, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "View Info →";
            // 
            // lab_RecAmt
            // 
            this.lab_RecAmt.AutoSize = true;
            this.lab_RecAmt.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_RecAmt.ForeColor = System.Drawing.Color.White;
            this.lab_RecAmt.Location = new System.Drawing.Point(3, 37);
            this.lab_RecAmt.Name = "lab_RecAmt";
            this.lab_RecAmt.Size = new System.Drawing.Size(41, 52);
            this.lab_RecAmt.TabIndex = 13;
            this.lab_RecAmt.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(564, 74);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(392, 45);
            this.panel7.TabIndex = 30;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(391, 408);
            this.panel9.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Today\'s Expense ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_Type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lab_Username);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(16, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 143);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // lab_Type
            // 
            this.lab_Type.AutoSize = true;
            this.lab_Type.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Type.Location = new System.Drawing.Point(332, 69);
            this.lab_Type.Name = "lab_Type";
            this.lab_Type.Size = new System.Drawing.Size(68, 24);
            this.lab_Type.TabIndex = 36;
            this.lab_Type.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Type :";
            // 
            // lab_Username
            // 
            this.lab_Username.AutoSize = true;
            this.lab_Username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Username.Location = new System.Drawing.Point(332, 36);
            this.lab_Username.Name = "lab_Username";
            this.lab_Username.Size = new System.Drawing.Size(124, 24);
            this.lab_Username.TabIndex = 35;
            this.lab_Username.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Username :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileShop.Properties.Resources.icons8_user_144;
            this.pictureBox1.Location = new System.Drawing.Point(9, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Expense
            // 
            this.dgv_Expense.AllowUserToAddRows = false;
            this.dgv_Expense.AllowUserToDeleteRows = false;
            this.dgv_Expense.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Expense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Expense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Amount});
            this.dgv_Expense.Location = new System.Drawing.Point(564, 116);
            this.dgv_Expense.Name = "dgv_Expense";
            this.dgv_Expense.ReadOnly = true;
            this.dgv_Expense.Size = new System.Drawing.Size(390, 94);
            this.dgv_Expense.TabIndex = 32;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "ESName";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "EAmount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 140;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panel8.Controls.Add(this.lab_ExpenseTotal);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(563, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 43);
            this.panel8.TabIndex = 33;
            // 
            // lab_ExpenseTotal
            // 
            this.lab_ExpenseTotal.AutoSize = true;
            this.lab_ExpenseTotal.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ExpenseTotal.ForeColor = System.Drawing.Color.White;
            this.lab_ExpenseTotal.Location = new System.Drawing.Point(128, 8);
            this.lab_ExpenseTotal.Name = "lab_ExpenseTotal";
            this.lab_ExpenseTotal.Size = new System.Drawing.Size(26, 32);
            this.lab_ExpenseTotal.TabIndex = 7;
            this.lab_ExpenseTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sub Total :";
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Font = new System.Drawing.Font("BigNoodleTitling", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lab_CompanyName.Location = new System.Drawing.Point(24, 15);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(251, 87);
            this.lab_CompanyName.TabIndex = 34;
            this.lab_CompanyName.Text = "COmpany";
            // 
            // pnl_Expense
            // 
            this.pnl_Expense.BackColor = System.Drawing.Color.White;
            this.pnl_Expense.Controls.Add(this.label2);
            this.pnl_Expense.Location = new System.Drawing.Point(562, 112);
            this.pnl_Expense.Name = "pnl_Expense";
            this.pnl_Expense.Size = new System.Drawing.Size(392, 97);
            this.pnl_Expense.TabIndex = 35;
            this.pnl_Expense.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(59, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 39);
            this.label2.TabIndex = 37;
            this.label2.Text = "No Expense Toay";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Location = new System.Drawing.Point(446, 406);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(209, 17);
            this.panel11.TabIndex = 41;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Controls.Add(this.label12);
            this.panel12.Location = new System.Drawing.Point(446, 258);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(209, 36);
            this.panel12.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 32);
            this.label12.TabIndex = 7;
            this.label12.Text = "Net Profit";
            // 
            // pnl_Profit
            // 
            this.pnl_Profit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.pnl_Profit.Controls.Add(this.label13);
            this.pnl_Profit.Controls.Add(this.label14);
            this.pnl_Profit.Controls.Add(this.lab_TodayProfit);
            this.pnl_Profit.Location = new System.Drawing.Point(446, 294);
            this.pnl_Profit.Name = "pnl_Profit";
            this.pnl_Profit.Size = new System.Drawing.Size(209, 112);
            this.pnl_Profit.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 32);
            this.label13.TabIndex = 38;
            this.label13.Text = "PKR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(129, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "View Info →";
            // 
            // lab_TodayProfit
            // 
            this.lab_TodayProfit.AutoSize = true;
            this.lab_TodayProfit.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TodayProfit.ForeColor = System.Drawing.Color.White;
            this.lab_TodayProfit.Location = new System.Drawing.Point(0, 37);
            this.lab_TodayProfit.Name = "lab_TodayProfit";
            this.lab_TodayProfit.Size = new System.Drawing.Size(41, 52);
            this.lab_TodayProfit.TabIndex = 13;
            this.lab_TodayProfit.Text = "0";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel14.Controls.Add(this.Lab_TodayPurchase);
            this.panel14.Controls.Add(this.label17);
            this.panel14.Location = new System.Drawing.Point(659, 258);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(295, 35);
            this.panel14.TabIndex = 44;
            // 
            // Lab_TodayPurchase
            // 
            this.Lab_TodayPurchase.AutoSize = true;
            this.Lab_TodayPurchase.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_TodayPurchase.ForeColor = System.Drawing.Color.White;
            this.Lab_TodayPurchase.Location = new System.Drawing.Point(97, 8);
            this.Lab_TodayPurchase.Name = "Lab_TodayPurchase";
            this.Lab_TodayPurchase.Size = new System.Drawing.Size(18, 27);
            this.Lab_TodayPurchase.TabIndex = 7;
            this.Lab_TodayPurchase.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(11, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 27);
            this.label17.TabIndex = 7;
            this.label17.Text = "Purchase :";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel15.Controls.Add(this.Lab_TodaySale);
            this.panel15.Controls.Add(this.label19);
            this.panel15.Location = new System.Drawing.Point(659, 296);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(295, 35);
            this.panel15.TabIndex = 44;
            // 
            // Lab_TodaySale
            // 
            this.Lab_TodaySale.AutoSize = true;
            this.Lab_TodaySale.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_TodaySale.ForeColor = System.Drawing.Color.White;
            this.Lab_TodaySale.Location = new System.Drawing.Point(97, 8);
            this.Lab_TodaySale.Name = "Lab_TodaySale";
            this.Lab_TodaySale.Size = new System.Drawing.Size(18, 27);
            this.Lab_TodaySale.TabIndex = 7;
            this.Lab_TodaySale.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(49, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 27);
            this.label19.TabIndex = 7;
            this.label19.Text = "Sale :";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel16.Controls.Add(this.Lab_TodayReceive);
            this.panel16.Controls.Add(this.label21);
            this.panel16.Location = new System.Drawing.Point(659, 334);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(295, 35);
            this.panel16.TabIndex = 44;
            // 
            // Lab_TodayReceive
            // 
            this.Lab_TodayReceive.AutoSize = true;
            this.Lab_TodayReceive.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_TodayReceive.ForeColor = System.Drawing.Color.White;
            this.Lab_TodayReceive.Location = new System.Drawing.Point(97, 8);
            this.Lab_TodayReceive.Name = "Lab_TodayReceive";
            this.Lab_TodayReceive.Size = new System.Drawing.Size(18, 27);
            this.Lab_TodayReceive.TabIndex = 7;
            this.Lab_TodayReceive.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(28, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 27);
            this.label21.TabIndex = 7;
            this.label21.Text = "Receive :";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.panel17.Controls.Add(this.Lab_TodayPaid);
            this.panel17.Controls.Add(this.label23);
            this.panel17.Location = new System.Drawing.Point(659, 372);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(295, 35);
            this.panel17.TabIndex = 44;
            // 
            // Lab_TodayPaid
            // 
            this.Lab_TodayPaid.AutoSize = true;
            this.Lab_TodayPaid.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_TodayPaid.ForeColor = System.Drawing.Color.White;
            this.Lab_TodayPaid.Location = new System.Drawing.Point(97, 8);
            this.Lab_TodayPaid.Name = "Lab_TodayPaid";
            this.Lab_TodayPaid.Size = new System.Drawing.Size(18, 27);
            this.Lab_TodayPaid.TabIndex = 7;
            this.Lab_TodayPaid.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("BigNoodleTitling", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(49, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 27);
            this.label23.TabIndex = 7;
            this.label23.Text = "Paid :";
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_date.ForeColor = System.Drawing.Color.DarkGray;
            this.lab_date.Location = new System.Drawing.Point(566, 9);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(168, 52);
            this.lab_date.TabIndex = 45;
            this.lab_date.Text = "Net Profit";
            // 
            // dateTime
            // 
            this.dateTime.Enabled = true;
            this.dateTime.Interval = 1000;
            this.dateTime.Tick += new System.EventHandler(this.dateTime_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.txt_OpeningBalance);
            this.groupBox2.Controls.Add(this.btn_OpenCounter);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(15, 645);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 87);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.Enabled = false;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(630, 25);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(253, 49);
            this.btn_Update.TabIndex = 328;
            this.btn_Update.Text = "  &Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_OpeningBalance
            // 
            this.txt_OpeningBalance.Enabled = false;
            this.txt_OpeningBalance.Location = new System.Drawing.Point(14, 37);
            this.txt_OpeningBalance.Name = "txt_OpeningBalance";
            this.txt_OpeningBalance.Size = new System.Drawing.Size(342, 37);
            this.txt_OpeningBalance.TabIndex = 130;
            // 
            // btn_OpenCounter
            // 
            this.btn_OpenCounter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OpenCounter.FlatAppearance.BorderSize = 0;
            this.btn_OpenCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenCounter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_OpenCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OpenCounter.Location = new System.Drawing.Point(364, 25);
            this.btn_OpenCounter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_OpenCounter.Name = "btn_OpenCounter";
            this.btn_OpenCounter.Size = new System.Drawing.Size(253, 49);
            this.btn_OpenCounter.TabIndex = 129;
            this.btn_OpenCounter.Text = "&Open Counter";
            this.btn_OpenCounter.UseVisualStyleBackColor = false;
            this.btn_OpenCounter.Click += new System.EventHandler(this.btn_OpenCounter_Click);
            // 
            // DashboardUpdate
            // 
            this.DashboardUpdate.Interval = 60000;
            this.DashboardUpdate.Tick += new System.EventHandler(this.DashboardUpdate_Tick);
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lab_date);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.pnl_Expense);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pnl_Profit);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chart_SaleOrder);
            this.Controls.Add(this.Chart_PurchaseOrder);
            this.Controls.Add(this.dgv_Expense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashboard";
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_PurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_SaleOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnl_Expense.ResumeLayout(false);
            this.pnl_Expense.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.pnl_Profit.ResumeLayout(false);
            this.pnl_Profit.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl Chart_PurchaseOrder;
        private DevExpress.XtraCharts.ChartControl Chart_SaleOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_PayAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lab_RecAmt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Expense;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_Type;
        private System.Windows.Forms.Label lab_Username;
        private System.Windows.Forms.Label lab_ExpenseTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnl_Expense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnl_Profit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lab_TodayProfit;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label Lab_TodayPurchase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label Lab_TodaySale;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label Lab_TodayReceive;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label Lab_TodayPaid;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Timer dateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_OpeningBalance;
        private System.Windows.Forms.Button btn_OpenCounter;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Timer DashboardUpdate;
    }
}