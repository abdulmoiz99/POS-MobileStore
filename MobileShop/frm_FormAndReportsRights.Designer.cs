namespace MobileShop
{
    partial class frm_FormAndReportsRights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FormAndReportsRights));
            this.dgv_FormRights = new System.Windows.Forms.DataGridView();
            this.RDRMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Access = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Add1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Print1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmb_UserType = new System.Windows.Forms.ComboBox();
            this.dgv_FormList = new System.Windows.Forms.DataGridView();
            this.FId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_FormRights
            // 
            this.dgv_FormRights.AllowUserToAddRows = false;
            this.dgv_FormRights.AllowUserToDeleteRows = false;
            this.dgv_FormRights.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FormRights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_FormRights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FormRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RDRMID,
            this.FormID,
            this.FormName,
            this.Access,
            this.Add1,
            this.Edit1,
            this.Delete1,
            this.Print1});
            this.dgv_FormRights.Location = new System.Drawing.Point(28, 154);
            this.dgv_FormRights.Name = "dgv_FormRights";
            this.dgv_FormRights.Size = new System.Drawing.Size(425, 158);
            this.dgv_FormRights.TabIndex = 0;
            this.dgv_FormRights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RDRMID
            // 
            this.RDRMID.DataPropertyName = "RDRMID";
            this.RDRMID.HeaderText = "RDRMID";
            this.RDRMID.Name = "RDRMID";
            this.RDRMID.Visible = false;
            // 
            // FormID
            // 
            this.FormID.DataPropertyName = "FormID";
            this.FormID.HeaderText = "FormID";
            this.FormID.Name = "FormID";
            this.FormID.ReadOnly = true;
            this.FormID.Visible = false;
            // 
            // FormName
            // 
            this.FormName.DataPropertyName = "FormName";
            this.FormName.HeaderText = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.ReadOnly = true;
            // 
            // Access
            // 
            this.Access.DataPropertyName = "Access";
            this.Access.HeaderText = "Access";
            this.Access.Name = "Access";
            this.Access.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Access.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Access.Width = 70;
            // 
            // Add1
            // 
            this.Add1.DataPropertyName = "Add1";
            this.Add1.HeaderText = "Add";
            this.Add1.Name = "Add1";
            this.Add1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Add1.Width = 50;
            // 
            // Edit1
            // 
            this.Edit1.DataPropertyName = "Edit1";
            this.Edit1.HeaderText = "Edit";
            this.Edit1.Name = "Edit1";
            this.Edit1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit1.Width = 50;
            // 
            // Delete1
            // 
            this.Delete1.DataPropertyName = "Delete1";
            this.Delete1.HeaderText = "Delete";
            this.Delete1.Name = "Delete1";
            this.Delete1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete1.Width = 60;
            // 
            // Print1
            // 
            this.Print1.DataPropertyName = "Print1";
            this.Print1.HeaderText = "Print";
            this.Print1.Name = "Print1";
            this.Print1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Print1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Print1.Width = 50;
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Location = new System.Drawing.Point(131, 115);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(322, 30);
            this.cmb_UserType.TabIndex = 2;
            this.cmb_UserType.SelectedIndexChanged += new System.EventHandler(this.cmb_UserType_SelectedIndexChanged);
            // 
            // dgv_FormList
            // 
            this.dgv_FormList.AllowUserToAddRows = false;
            this.dgv_FormList.AllowUserToDeleteRows = false;
            this.dgv_FormList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FormList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FId,
            this.FName});
            this.dgv_FormList.Location = new System.Drawing.Point(459, 118);
            this.dgv_FormList.Name = "dgv_FormList";
            this.dgv_FormList.ReadOnly = true;
            this.dgv_FormList.Size = new System.Drawing.Size(35, 10);
            this.dgv_FormList.TabIndex = 4;
            // 
            // FId
            // 
            this.FId.DataPropertyName = "FormID";
            this.FId.HeaderText = "FId";
            this.FId.Name = "FId";
            this.FId.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FormName";
            this.FName.HeaderText = "FName";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Type :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_exitForm);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 63);
            this.panel2.TabIndex = 181;
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
            this.btn_exitForm.Location = new System.Drawing.Point(761, 0);
            this.btn_exitForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exitForm.Name = "btn_exitForm";
            this.btn_exitForm.Size = new System.Drawing.Size(118, 63);
            this.btn_exitForm.TabIndex = 1017;
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
            this.label4.Size = new System.Drawing.Size(366, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Form And Reports Rights ";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 32);
            this.panel1.TabIndex = 180;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(28, 321);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(425, 43);
            this.btn_Update.TabIndex = 328;
            this.btn_Update.Text = "  &Update Rights";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_FormAndReportsRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 447);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_FormList);
            this.Controls.Add(this.cmb_UserType);
            this.Controls.Add(this.dgv_FormRights);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FormAndReportsRights";
            this.Text = "frm_FormAndReportsRights";
            this.Load += new System.EventHandler(this.frm_FormAndReportsRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FormRights;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.DataGridView dgv_FormList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDRMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Access;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edit1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Print1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exitForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
    }
}