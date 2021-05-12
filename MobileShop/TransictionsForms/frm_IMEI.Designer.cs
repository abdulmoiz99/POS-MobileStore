namespace MobileShop.TransictionsForms
{
    partial class frm_IMEI
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
            this.lab_ItemName = new System.Windows.Forms.Label();
            this.dgv_IMEI = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Lab_Quantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMEI)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_ItemName
            // 
            this.lab_ItemName.AutoSize = true;
            this.lab_ItemName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lab_ItemName.Location = new System.Drawing.Point(177, 16);
            this.lab_ItemName.Name = "lab_ItemName";
            this.lab_ItemName.Size = new System.Drawing.Size(60, 28);
            this.lab_ItemName.TabIndex = 0;
            this.lab_ItemName.Text = "IMEI";
            // 
            // dgv_IMEI
            // 
            this.dgv_IMEI.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_IMEI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_IMEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IMEI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMEI,
            this.BarCode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_IMEI.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_IMEI.Location = new System.Drawing.Point(14, 103);
            this.dgv_IMEI.Name = "dgv_IMEI";
            this.dgv_IMEI.Size = new System.Drawing.Size(446, 229);
            this.dgv_IMEI.TabIndex = 1;
            this.dgv_IMEI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_IMEI_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Item :";
            // 
            // Lab_Quantity
            // 
            this.Lab_Quantity.AutoSize = true;
            this.Lab_Quantity.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Lab_Quantity.Location = new System.Drawing.Point(177, 58);
            this.Lab_Quantity.Name = "Lab_Quantity";
            this.Lab_Quantity.Size = new System.Drawing.Size(60, 28);
            this.Lab_Quantity.TabIndex = 0;
            this.Lab_Quantity.Text = "IMEI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item Name :";
            // 
            // IMEI
            // 
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.Name = "IMEI";
            this.IMEI.Width = 200;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.Width = 200;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_Save.Image = global::MobileShop.Properties.Resources.icons8_save_close_36;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(14, 341);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(446, 75);
            this.btn_Save.TabIndex = 132;
            this.btn_Save.Text = "  &Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_IMEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 437);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_IMEI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab_Quantity);
            this.Controls.Add(this.lab_ItemName);
            this.Name = "frm_IMEI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMEI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lab_ItemName;
        private System.Windows.Forms.DataGridView dgv_IMEI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lab_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.Button btn_Save;
    }
}