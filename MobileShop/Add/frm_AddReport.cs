using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class frm_AddReport : Form
    {
        public frm_AddReport()
        {
            InitializeComponent();
        }
        int mode;
        private void AllClear()
        {
            txt_Name.Text = "";
            txt_Find.Text = "";

        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            AllClear();
            btn_edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_Name.Enabled = true;
            dgv_FromName.Enabled = false;
            txt_Name.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_Name.Enabled = true;
            dgv_FromName.Enabled = true;

            txt_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {
                SQL.NonScalarQuery("Insert Into ReportSetup(ReportName) values ('" + txt_Name.Text + "')");
                MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AllClear();
                btn_cancel_Click(sender, e);
                frm_AddReport_Load(sender, e);
            }
            else if (mode == 2)
            {
                if (txt_DataGridViewIndex.Text == "")
                {
                    MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SQL.NonScalarQuery("Update ReportSetup set ReportName = '" + txt_Name.Text + "' where ReportID=" + txt_DataGridViewIndex.Text + "");
                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AllClear();
                btn_cancel_Click(sender, e);
                frm_AddReport_Load(sender, e);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_edit.Enabled = true;
            btn_Delete.Enabled = false;
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_Name.Enabled = false;
            dgv_FromName.Enabled = true;

        }

        private void dgv_FromName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Name.Text = "";
                int index = e.RowIndex;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_FromName.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells["ReportID"].Value.ToString();
                    txt_Name.Text = selectedrow.Cells["ReportName"].Value.ToString();
                }
                index = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void frm_AddReport_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_FromName, "Select * from ReportSetup");
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_FromName, "select ReportId,ReportName from ReportSetup where CompanyID=" + Main.CompanyID + " AND CAST(ReportName as varchar)  like '%" + txt_Find.Text + "%'");
        }
    }
}
