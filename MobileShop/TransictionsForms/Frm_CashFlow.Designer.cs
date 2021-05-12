namespace MobileShop.TransictionsForms
{
    partial class Frm_CashFlow
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
            this.rdo_receviable = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_PartyName = new SergeUtils.EasyCompletionComboBox();
            this.rdo_Payable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_CashFlow = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_PMID = new System.Windows.Forms.Label();
            this.txt_CAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Balance = new System.Windows.Forms.Label();
            this.lab_Amt = new System.Windows.Forms.Label();
            this.lab_Mode = new System.Windows.Forms.Label();
            this.lab_PartyName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashFlow)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_receviable
            // 
            this.rdo_receviable.AutoSize = true;
            this.rdo_receviable.Enabled = false;
            this.rdo_receviable.Location = new System.Drawing.Point(238, 176);
            this.rdo_receviable.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rdo_receviable.Name = "rdo_receviable";
            this.rdo_receviable.Size = new System.Drawing.Size(115, 24);
            this.rdo_receviable.TabIndex = 204;
            this.rdo_receviable.Text = "RECEVIABLE";
            this.rdo_receviable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 203;
            this.label2.Text = "Payment Type :";
            // 
            // cmb_PartyName
            // 
            this.cmb_PartyName.Enabled = false;
            this.cmb_PartyName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PartyName.FormattingEnabled = true;
            this.cmb_PartyName.Location = new System.Drawing.Point(145, 215);
            this.cmb_PartyName.Margin = new System.Windows.Forms.Padding(9);
            this.cmb_PartyName.Name = "cmb_PartyName";
            this.cmb_PartyName.Size = new System.Drawing.Size(283, 29);
            this.cmb_PartyName.TabIndex = 202;
            // 
            // rdo_Payable
            // 
            this.rdo_Payable.AutoSize = true;
            this.rdo_Payable.Checked = true;
            this.rdo_Payable.Enabled = false;
            this.rdo_Payable.Location = new System.Drawing.Point(146, 176);
            this.rdo_Payable.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rdo_Payable.Name = "rdo_Payable";
            this.rdo_Payable.Size = new System.Drawing.Size(93, 24);
            this.rdo_Payable.TabIndex = 201;
            this.rdo_Payable.TabStop = true;
            this.rdo_Payable.Text = "PAYABLE ";
            this.rdo_Payable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 200;
            this.label1.Text = "Party Name :";
            // 
            // datetimepicker
            // 
            this.datetimepicker.CustomFormat = "dd/MM/yyyy";
            this.datetimepicker.Enabled = false;
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker.Location = new System.Drawing.Point(145, 128);
            this.datetimepicker.Margin = new System.Windows.Forms.Padding(4);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(208, 26);
            this.datetimepicker.TabIndex = 1001;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1002;
            this.label3.Text = "Date :";
            // 
            // dgv_CashFlow
            // 
            this.dgv_CashFlow.AllowUserToAddRows = false;
            this.dgv_CashFlow.AllowUserToDeleteRows = false;
            this.dgv_CashFlow.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CashFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CashFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.PartyName,
            this.Mode1,
            this.RecNo,
            this.PMID,
            this.Amount,
            this.Balance,
            this.PayAmt});
            this.dgv_CashFlow.Enabled = false;
            this.dgv_CashFlow.Location = new System.Drawing.Point(37, 456);
            this.dgv_CashFlow.Name = "dgv_CashFlow";
            this.dgv_CashFlow.Size = new System.Drawing.Size(615, 260);
            this.dgv_CashFlow.TabIndex = 1003;
            this.dgv_CashFlow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CashFlow_CellContentClick);
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // PartyName
            // 
            this.PartyName.DataPropertyName = "PartyName";
            this.PartyName.HeaderText = "Party Name";
            this.PartyName.Name = "PartyName";
            this.PartyName.Width = 150;
            // 
            // Mode1
            // 
            this.Mode1.DataPropertyName = "Mode";
            this.Mode1.HeaderText = "Mode";
            this.Mode1.Name = "Mode1";
            this.Mode1.Visible = false;
            // 
            // RecNo
            // 
            this.RecNo.DataPropertyName = "RecNo";
            this.RecNo.HeaderText = "Invoice No";
            this.RecNo.Name = "RecNo";
            this.RecNo.Width = 120;
            // 
            // PMID
            // 
            this.PMID.DataPropertyName = "RECID";
            this.PMID.HeaderText = "RecID";
            this.PMID.Name = "PMID";
            this.PMID.Visible = false;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "CFAmt";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // PayAmt
            // 
            this.PayAmt.HeaderText = "Paid Amount";
            this.PayAmt.Name = "PayAmt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 63);
            this.panel2.TabIndex = 1008;
            // 
            // btn_exitForm
            // 
            this.btn_exitForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exitForm.FlatAppearance.BorderSize = 0;
            this.btn_exitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_exitForm.Image = global::MobileShop.Properties.Resources.icons8_cancel_36;
            this.btn_exitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exitForm.Location = new System.Drawing.Point(750, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 63);
            this.btn_exitForm.TabIndex = 1015;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cash Flow";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 32);
            this.panel1.TabIndex = 1007;
            // 
            // lab_PMID
            // 
            this.lab_PMID.AutoSize = true;
            this.lab_PMID.Location = new System.Drawing.Point(335, 158);
            this.lab_PMID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_PMID.Name = "lab_PMID";
            this.lab_PMID.Size = new System.Drawing.Size(25, 20);
            this.lab_PMID.TabIndex = 1009;
            this.lab_PMID.Text = "ID";
            this.lab_PMID.Visible = false;
            // 
            // txt_CAmount
            // 
            this.txt_CAmount.Location = new System.Drawing.Point(413, 39);
            this.txt_CAmount.Name = "txt_CAmount";
            this.txt_CAmount.Size = new System.Drawing.Size(190, 26);
            this.txt_CAmount.TabIndex = 1010;
            this.txt_CAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CAmount_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 1011;
            this.label10.Text = "Amount :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 56);
            this.button1.TabIndex = 1012;
            this.button1.Text = "Perform Tranaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_PMID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_CAmount);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(37, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 194);
            this.groupBox2.TabIndex = 1013;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_Balance);
            this.groupBox1.Controls.Add(this.lab_Amt);
            this.groupBox1.Controls.Add(this.lab_Mode);
            this.groupBox1.Controls.Add(this.lab_PartyName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 165);
            this.groupBox1.TabIndex = 1004;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // lab_Balance
            // 
            this.lab_Balance.AutoSize = true;
            this.lab_Balance.Location = new System.Drawing.Point(117, 124);
            this.lab_Balance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_Balance.Name = "lab_Balance";
            this.lab_Balance.Size = new System.Drawing.Size(78, 20);
            this.lab_Balance.TabIndex = 1010;
            this.lab_Balance.Text = "Balance :";
            // 
            // lab_Amt
            // 
            this.lab_Amt.AutoSize = true;
            this.lab_Amt.Location = new System.Drawing.Point(117, 91);
            this.lab_Amt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_Amt.Name = "lab_Amt";
            this.lab_Amt.Size = new System.Drawing.Size(74, 20);
            this.lab_Amt.TabIndex = 1009;
            this.lab_Amt.Text = "Amount :";
            // 
            // lab_Mode
            // 
            this.lab_Mode.AutoSize = true;
            this.lab_Mode.Location = new System.Drawing.Point(117, 28);
            this.lab_Mode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_Mode.Name = "lab_Mode";
            this.lab_Mode.Size = new System.Drawing.Size(53, 20);
            this.lab_Mode.TabIndex = 1008;
            this.lab_Mode.Text = "Date :";
            // 
            // lab_PartyName
            // 
            this.lab_PartyName.AutoSize = true;
            this.lab_PartyName.Location = new System.Drawing.Point(117, 61);
            this.lab_PartyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_PartyName.Name = "lab_PartyName";
            this.lab_PartyName.Size = new System.Drawing.Size(102, 20);
            this.lab_PartyName.TabIndex = 1006;
            this.lab_PartyName.Text = "Party Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 1005;
            this.label9.Text = "Balance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 1004;
            this.label8.Text = "Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 1003;
            this.label7.Text = "Mode :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 201;
            this.label4.Text = "Party Name :";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(770, 276);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(62, 57);
            this.btn_generate.TabIndex = 1013;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Visible = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_cancel.Image = global::MobileShop.Properties.Resources.icons8_undo_36;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(519, 175);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 53);
            this.btn_cancel.TabIndex = 1016;
            this.btn_cancel.Text = "    &Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.FlatAppearance.BorderSize = 0;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Image = global::MobileShop.Properties.Resources.icons8_search_30;
            this.btn_Find.Location = new System.Drawing.Point(431, 215);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(52, 29);
            this.btn_Find.TabIndex = 1015;
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click_1);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_New.Image = global::MobileShop.Properties.Resources.icons8_add_folder_36;
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(519, 110);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(133, 53);
            this.btn_New.TabIndex = 1014;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click_1);
            // 
            // Frm_CashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 722);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_CashFlow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.rdo_receviable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_PartyName);
            this.Controls.Add(this.rdo_Payable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CashFlow";
            this.Load += new System.EventHandler(this.Frm_CashFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashFlow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_receviable;
        private System.Windows.Forms.Label label2;
        internal SergeUtils.EasyCompletionComboBox cmb_PartyName;
        private System.Windows.Forms.RadioButton rdo_Payable;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_CashFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_PMID;
        private System.Windows.Forms.TextBox txt_CAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_Balance;
        private System.Windows.Forms.Label lab_Amt;
        private System.Windows.Forms.Label lab_Mode;
        private System.Windows.Forms.Label lab_PartyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayAmt;
    }
}