namespace MobileShop
{
    partial class frm_AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_Type = new SergeUtils.EasyCompletionComboBox();
            this.cmb_Brand = new SergeUtils.EasyCompletionComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.cmb_Unit = new SergeUtils.EasyCompletionComboBox();
            this.txt_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_SalePrice = new System.Windows.Forms.TextBox();
            this.dgv_BrandSetup = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.txt_dgvRowId = new System.Windows.Forms.TextBox();
            this.rdo_No = new System.Windows.Forms.RadioButton();
            this.rdo_Yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddUnit = new System.Windows.Forms.Button();
            this.btn_AddBrand = new System.Windows.Forms.Button();
            this.btn_AddType = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrandSetup)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 31);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(227, 149);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(249, 33);
            this.txt_Name.TabIndex = 209;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label9.Location = new System.Drawing.Point(134, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 208;
            this.label9.Text = "Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label10.Location = new System.Drawing.Point(148, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 208;
            this.label10.Text = "Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label11.Location = new System.Drawing.Point(152, 197);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 24);
            this.label11.TabIndex = 208;
            this.label11.Text = "Type :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label12.Location = new System.Drawing.Point(140, 240);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 208;
            this.label12.Text = "Brand :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label14.Location = new System.Drawing.Point(49, 317);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 24);
            this.label14.TabIndex = 208;
            this.label14.Text = "Purchase Price :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label15.Location = new System.Drawing.Point(119, 279);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 24);
            this.label15.TabIndex = 208;
            this.label15.Text = "Quantity:";
            // 
            // cmb_Type
            // 
            this.cmb_Type.Enabled = false;
            this.cmb_Type.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(227, 191);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(249, 30);
            this.cmb_Type.TabIndex = 210;
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.Enabled = false;
            this.cmb_Brand.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(227, 234);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(249, 30);
            this.cmb_Brand.TabIndex = 210;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 63);
            this.panel2.TabIndex = 216;
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
            this.btn_exitForm.Location = new System.Drawing.Point(620, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 63);
            this.btn_exitForm.TabIndex = 1016;
            this.btn_exitForm.Text = "     &Close";
            this.btn_exitForm.UseVisualStyleBackColor = false;
            this.btn_exitForm.Click += new System.EventHandler(this.btn_exitForm_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(11, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 36);
            this.label17.TabIndex = 1;
            this.label17.Text = "Item Setup";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 32);
            this.panel1.TabIndex = 215;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Location = new System.Drawing.Point(534, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 302);
            this.groupBox2.TabIndex = 214;
            this.groupBox2.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Save.Image = global::MobileShop.Properties.Resources.icons8_save_close_36;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(8, 134);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 43);
            this.btn_Save.TabIndex = 131;
            this.btn_Save.Text = "  &Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_cancel.Image = global::MobileShop.Properties.Resources.icons8_undo_36;
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
            this.btn_Delete.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Delete.Image = global::MobileShop.Properties.Resources.icons8_delete_bin_36;
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
            this.btn_edit.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_New.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_New.Image = global::MobileShop.Properties.Resources.icons8_add_folder_36;
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
            // txt_Quantity
            // 
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Enabled = false;
            this.txt_Quantity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(227, 277);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(165, 33);
            this.txt_Quantity.TabIndex = 209;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.Enabled = false;
            this.cmb_Unit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.Location = new System.Drawing.Point(398, 277);
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(78, 32);
            this.cmb_Unit.TabIndex = 210;
            // 
            // txt_PurchasePrice
            // 
            this.txt_PurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PurchasePrice.Enabled = false;
            this.txt_PurchasePrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PurchasePrice.Location = new System.Drawing.Point(227, 317);
            this.txt_PurchasePrice.Name = "txt_PurchasePrice";
            this.txt_PurchasePrice.Size = new System.Drawing.Size(249, 33);
            this.txt_PurchasePrice.TabIndex = 217;
            this.txt_PurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PurchasePrice_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label18.Location = new System.Drawing.Point(100, 362);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 24);
            this.label18.TabIndex = 208;
            this.label18.Text = "Sale Price :";
            // 
            // txt_SalePrice
            // 
            this.txt_SalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SalePrice.Enabled = false;
            this.txt_SalePrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalePrice.Location = new System.Drawing.Point(227, 362);
            this.txt_SalePrice.Name = "txt_SalePrice";
            this.txt_SalePrice.Size = new System.Drawing.Size(249, 33);
            this.txt_SalePrice.TabIndex = 217;
            this.txt_SalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SalePrice_KeyPress);
            // 
            // dgv_BrandSetup
            // 
            this.dgv_BrandSetup.AllowUserToAddRows = false;
            this.dgv_BrandSetup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_BrandSetup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BrandSetup.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BrandSetup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BrandSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BrandSetup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IMName,
            this.ITID,
            this.ITName,
            this.IBID,
            this.IBName,
            this.IMQty,
            this.IMPurchasePrice,
            this.IMSalesPrice,
            this.ITActive});
            this.dgv_BrandSetup.Location = new System.Drawing.Point(12, 509);
            this.dgv_BrandSetup.Name = "dgv_BrandSetup";
            this.dgv_BrandSetup.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_BrandSetup.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BrandSetup.RowTemplate.Height = 35;
            this.dgv_BrandSetup.Size = new System.Drawing.Size(707, 198);
            this.dgv_BrandSetup.TabIndex = 218;
            this.dgv_BrandSetup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BrandSetup_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IMID";
            this.Column1.HeaderText = "S.No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // IMName
            // 
            this.IMName.DataPropertyName = "IMName";
            this.IMName.HeaderText = "Name";
            this.IMName.Name = "IMName";
            this.IMName.ReadOnly = true;
            this.IMName.Width = 170;
            // 
            // ITID
            // 
            this.ITID.DataPropertyName = "ITID";
            this.ITID.HeaderText = "ITID";
            this.ITID.Name = "ITID";
            this.ITID.ReadOnly = true;
            this.ITID.Visible = false;
            // 
            // ITName
            // 
            this.ITName.DataPropertyName = "ITName";
            this.ITName.HeaderText = "Type";
            this.ITName.Name = "ITName";
            this.ITName.ReadOnly = true;
            // 
            // IBID
            // 
            this.IBID.DataPropertyName = "IBID";
            this.IBID.HeaderText = "IBID";
            this.IBID.Name = "IBID";
            this.IBID.ReadOnly = true;
            this.IBID.Visible = false;
            // 
            // IBName
            // 
            this.IBName.DataPropertyName = "IBName";
            this.IBName.HeaderText = "Brand";
            this.IBName.Name = "IBName";
            this.IBName.ReadOnly = true;
            // 
            // IMQty
            // 
            this.IMQty.DataPropertyName = "IMQty";
            this.IMQty.HeaderText = "Quantity";
            this.IMQty.Name = "IMQty";
            this.IMQty.ReadOnly = true;
            // 
            // IMPurchasePrice
            // 
            this.IMPurchasePrice.DataPropertyName = "IMPurchasePrice";
            this.IMPurchasePrice.HeaderText = "Purchase Price";
            this.IMPurchasePrice.Name = "IMPurchasePrice";
            this.IMPurchasePrice.ReadOnly = true;
            // 
            // IMSalesPrice
            // 
            this.IMSalesPrice.DataPropertyName = "IMSalesPrice";
            this.IMSalesPrice.HeaderText = "Sale Price";
            this.IMSalesPrice.Name = "IMSalesPrice";
            this.IMSalesPrice.ReadOnly = true;
            // 
            // ITActive
            // 
            this.ITActive.DataPropertyName = "IMActive";
            this.ITActive.HeaderText = "Active";
            this.ITActive.Name = "ITActive";
            this.ITActive.ReadOnly = true;
            this.ITActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ITActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_Find);
            this.groupBox1.Location = new System.Drawing.Point(17, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 52);
            this.groupBox1.TabIndex = 219;
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
            // txt_Find
            // 
            this.txt_Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Find.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(6, 16);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(289, 26);
            this.txt_Find.TabIndex = 163;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // txt_dgvRowId
            // 
            this.txt_dgvRowId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dgvRowId.Enabled = false;
            this.txt_dgvRowId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dgvRowId.Location = new System.Drawing.Point(700, 460);
            this.txt_dgvRowId.Name = "txt_dgvRowId";
            this.txt_dgvRowId.Size = new System.Drawing.Size(24, 33);
            this.txt_dgvRowId.TabIndex = 221;
            this.txt_dgvRowId.Visible = false;
            // 
            // rdo_No
            // 
            this.rdo_No.AutoSize = true;
            this.rdo_No.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.rdo_No.Location = new System.Drawing.Point(294, 409);
            this.rdo_No.Name = "rdo_No";
            this.rdo_No.Size = new System.Drawing.Size(58, 28);
            this.rdo_No.TabIndex = 224;
            this.rdo_No.Text = "No";
            this.rdo_No.UseVisualStyleBackColor = true;
            // 
            // rdo_Yes
            // 
            this.rdo_Yes.AutoSize = true;
            this.rdo_Yes.Checked = true;
            this.rdo_Yes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.rdo_Yes.Location = new System.Drawing.Point(226, 409);
            this.rdo_Yes.Name = "rdo_Yes";
            this.rdo_Yes.Size = new System.Drawing.Size(63, 28);
            this.rdo_Yes.TabIndex = 223;
            this.rdo_Yes.TabStop = true;
            this.rdo_Yes.Text = "Yes";
            this.rdo_Yes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(132, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 222;
            this.label2.Text = "Active :";
            // 
            // btn_AddUnit
            // 
            this.btn_AddUnit.FlatAppearance.BorderSize = 0;
            this.btn_AddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUnit.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddUnit.Image")));
            this.btn_AddUnit.Location = new System.Drawing.Point(482, 280);
            this.btn_AddUnit.Name = "btn_AddUnit";
            this.btn_AddUnit.Size = new System.Drawing.Size(34, 30);
            this.btn_AddUnit.TabIndex = 220;
            this.btn_AddUnit.UseVisualStyleBackColor = true;
            this.btn_AddUnit.Click += new System.EventHandler(this.btn_AddUnit_Click);
            // 
            // btn_AddBrand
            // 
            this.btn_AddBrand.FlatAppearance.BorderSize = 0;
            this.btn_AddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddBrand.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddBrand.Image")));
            this.btn_AddBrand.Location = new System.Drawing.Point(482, 234);
            this.btn_AddBrand.Name = "btn_AddBrand";
            this.btn_AddBrand.Size = new System.Drawing.Size(34, 30);
            this.btn_AddBrand.TabIndex = 220;
            this.btn_AddBrand.UseVisualStyleBackColor = true;
            this.btn_AddBrand.Click += new System.EventHandler(this.btn_AddBrand_Click);
            // 
            // btn_AddType
            // 
            this.btn_AddType.FlatAppearance.BorderSize = 0;
            this.btn_AddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddType.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddType.Image")));
            this.btn_AddType.Location = new System.Drawing.Point(482, 191);
            this.btn_AddType.Name = "btn_AddType";
            this.btn_AddType.Size = new System.Drawing.Size(34, 30);
            this.btn_AddType.TabIndex = 220;
            this.btn_AddType.UseVisualStyleBackColor = true;
            this.btn_AddType.Click += new System.EventHandler(this.btn_AddType_Click);
            // 
            // frm_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 719);
            this.Controls.Add(this.rdo_No);
            this.Controls.Add(this.rdo_Yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dgvRowId);
            this.Controls.Add(this.btn_AddUnit);
            this.Controls.Add(this.btn_AddBrand);
            this.Controls.Add(this.btn_AddType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_BrandSetup);
            this.Controls.Add(this.txt_SalePrice);
            this.Controls.Add(this.txt_PurchasePrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_Unit);
            this.Controls.Add(this.cmb_Brand);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddItem";
            this.Load += new System.EventHandler(this.frm_AddItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BrandSetup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        internal SergeUtils.EasyCompletionComboBox cmb_Type;
        internal SergeUtils.EasyCompletionComboBox cmb_Brand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.TextBox txt_Quantity;
        internal SergeUtils.EasyCompletionComboBox cmb_Unit;
        private System.Windows.Forms.TextBox txt_PurchasePrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_SalePrice;
        private System.Windows.Forms.DataGridView dgv_BrandSetup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button btn_AddType;
        private System.Windows.Forms.Button btn_AddBrand;
        private System.Windows.Forms.Button btn_AddUnit;
        private System.Windows.Forms.TextBox txt_dgvRowId;
        private System.Windows.Forms.RadioButton rdo_No;
        private System.Windows.Forms.RadioButton rdo_Yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSalesPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ITActive;
        private System.Windows.Forms.Button btn_exitForm;
    }
}