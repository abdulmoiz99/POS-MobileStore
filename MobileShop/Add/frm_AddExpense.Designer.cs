namespace MobileShop
{
    partial class frm_AddExpense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddExpense));
            this.txt_DataGridViewIndex = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_BrandSetup = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EESID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ExpenseTitle = new SergeUtils.EasyCompletionComboBox();
            this.datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_AddType = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrandSetup)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DataGridViewIndex
            // 
            this.txt_DataGridViewIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataGridViewIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataGridViewIndex.Location = new System.Drawing.Point(422, 413);
            this.txt_DataGridViewIndex.Name = "txt_DataGridViewIndex";
            this.txt_DataGridViewIndex.Size = new System.Drawing.Size(24, 31);
            this.txt_DataGridViewIndex.TabIndex = 193;
            this.txt_DataGridViewIndex.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 63);
            this.panel2.TabIndex = 191;
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
            this.btn_exitForm.Location = new System.Drawing.Point(562, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 63);
            this.btn_exitForm.TabIndex = 1016;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Expense ";
            // 
            // dgv_BrandSetup
            // 
            this.dgv_BrandSetup.AllowUserToAddRows = false;
            this.dgv_BrandSetup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_BrandSetup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BrandSetup.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BrandSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BrandSetup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.EESID,
            this.Title,
            this.Amount,
            this.Description,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BrandSetup.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BrandSetup.Location = new System.Drawing.Point(30, 458);
            this.dgv_BrandSetup.Name = "dgv_BrandSetup";
            this.dgv_BrandSetup.ReadOnly = true;
            this.dgv_BrandSetup.RowTemplate.Height = 35;
            this.dgv_BrandSetup.Size = new System.Drawing.Size(627, 198);
            this.dgv_BrandSetup.TabIndex = 189;
            this.dgv_BrandSetup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BrandSetup_CellContentClick);
            // 
            // EID
            // 
            this.EID.DataPropertyName = "EID";
            this.EID.HeaderText = "ID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            this.EID.Visible = false;
            // 
            // EESID
            // 
            this.EESID.DataPropertyName = "EESID";
            this.EESID.HeaderText = "EESID";
            this.EESID.Name = "EESID";
            this.EESID.ReadOnly = true;
            this.EESID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "ESName";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 140;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "EAmount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "EDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 220;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "EDate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // txt_Amount
            // 
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amount.Enabled = false;
            this.txt_Amount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(166, 210);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(249, 29);
            this.txt_Amount.TabIndex = 185;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Location = new System.Drawing.Point(467, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 302);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(8, 134);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 43);
            this.btn_Save.TabIndex = 131;
            this.btn_Save.Text = "  &Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(8, 246);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(172, 43);
            this.btn_cancel.TabIndex = 130;
            this.btn_cancel.Text = "  &Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(8, 190);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(172, 43);
            this.btn_Delete.TabIndex = 129;
            this.btn_Delete.Text = "  &Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(8, 78);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(172, 43);
            this.btn_edit.TabIndex = 128;
            this.btn_edit.Text = "  &Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(8, 22);
            this.btn_New.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(172, 43);
            this.btn_New.TabIndex = 127;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(6, 20);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(289, 24);
            this.txt_Find.TabIndex = 163;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 32);
            this.panel1.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(101, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 183;
            this.label1.Text = "Title :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_Find);
            this.groupBox1.Location = new System.Drawing.Point(77, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 52);
            this.groupBox1.TabIndex = 192;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(26, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 194;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(55, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 195;
            this.label3.Text = "Amount :";
            // 
            // cmb_ExpenseTitle
            // 
            this.cmb_ExpenseTitle.Enabled = false;
            this.cmb_ExpenseTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ExpenseTitle.FormattingEnabled = true;
            this.cmb_ExpenseTitle.Location = new System.Drawing.Point(166, 165);
            this.cmb_ExpenseTitle.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ExpenseTitle.Name = "cmb_ExpenseTitle";
            this.cmb_ExpenseTitle.Size = new System.Drawing.Size(249, 29);
            this.cmb_ExpenseTitle.TabIndex = 196;
            // 
            // datetimePicker
            // 
            this.datetimePicker.CustomFormat = "dd/MM/yyyy";
            this.datetimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimePicker.Location = new System.Drawing.Point(166, 114);
            this.datetimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datetimePicker.Name = "datetimePicker";
            this.datetimePicker.Size = new System.Drawing.Size(142, 29);
            this.datetimePicker.TabIndex = 197;
            // 
            // txt_Description
            // 
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Description.Enabled = false;
            this.txt_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(166, 253);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(249, 129);
            this.txt_Description.TabIndex = 185;
            // 
            // btn_AddType
            // 
            this.btn_AddType.FlatAppearance.BorderSize = 0;
            this.btn_AddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddType.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddType.Image")));
            this.btn_AddType.Location = new System.Drawing.Point(422, 164);
            this.btn_AddType.Name = "btn_AddType";
            this.btn_AddType.Size = new System.Drawing.Size(34, 30);
            this.btn_AddType.TabIndex = 221;
            this.btn_AddType.UseVisualStyleBackColor = true;
            this.btn_AddType.Click += new System.EventHandler(this.btn_AddType_Click);
            // 
            // frm_AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 686);
            this.Controls.Add(this.btn_AddType);
            this.Controls.Add(this.cmb_ExpenseTitle);
            this.Controls.Add(this.datetimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DataGridViewIndex);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_BrandSetup);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddExpense";
            this.Activated += new System.EventHandler(this.frm_AddExpense_Activated);
            this.Load += new System.EventHandler(this.frm_AddExpense_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrandSetup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DataGridViewIndex;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_BrandSetup;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal SergeUtils.EasyCompletionComboBox cmb_ExpenseTitle;
        internal System.Windows.Forms.DateTimePicker datetimePicker;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_AddType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EESID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btn_exitForm;
    }
}