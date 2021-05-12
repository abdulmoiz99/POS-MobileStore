using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.SetupForms
{
    public partial class frm_ExpenseSetup : Form
    {
        int mode;
        String FName = "ExpenseSetup";
        public frm_ExpenseSetup()
        {
            if (Rights.Access(Main.RDRMID, FName) == true)
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("You Dont Have Access To View The Page", "Access Denied", MessageBoxButtons.OK);
                this.Close();
            }
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
            txt_Name.Focus();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_DataGridViewIndex.Text != "")
            {
                mode = 2;
                btn_edit.Enabled = false;
                btn_New.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = true;
                btn_cancel.Enabled = true;
                txt_Name.Enabled = true;
                txt_Name.Focus();
            }
            else MessageBox.Show("Please Select A record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int active = 1;
            if (rdo_Yes.Checked == true)
            {
                active = 1;
            }
            else active = 0;
            if (mode == 1)
            {
                if (Rights.Add(Main.RDRMID, FName) == false)
                {
                    MessageBox.Show("You donot have permision to add new item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txt_Name.Text == "")
                {
                    MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("Insert Into ExpenseSetup(ESName,ESActive,CompanyID) values ('" + txt_Name.Text + "'," + active + "," + Main.CompanyID + ")");
                        AllClear();
                        frm_ExpenseSetup_Load(sender, e);
                        mode = 0;
                        MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_cancel_Click(sender, e);
                    }
                }
            }
            else if (mode == 2)
            {
                if (Rights.Edit(Main.RDRMID, FName) == false)
                {
                    MessageBox.Show("You donot have permision to edit item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To UPDATE the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("update ExpenseSetup set ESName='" + txt_Name.Text + "' where ESID=" + int.Parse(txt_DataGridViewIndex.Text) + "");
                        AllClear();
                        frm_ExpenseSetup_Load(sender, e);
                        mode = 0;
                        MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_cancel_Click(sender, e);
                    }
                }

            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Rights.Delete(Main.RDRMID, FName) == true)
            {
            }
            else MessageBox.Show("You donot have permision to delete item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }
        private void dgv_BrandSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Name.Text = "";
                int index = e.RowIndex;
                string active = "";
                int Result;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_BrandSetup.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells[0].Value.ToString();
                    txt_Name.Text = selectedrow.Cells[1].Value.ToString();
                    active = selectedrow.Cells[2].Value.ToString();
                    Result = string.Compare(active, "False");
                    if (Result == 0)
                    {
                        rdo_No.Checked = true;
                    }
                    else
                    {
                        rdo_Yes.Checked = true;
                    }
                }
                index = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select ESID,ESName,ESActive from ExpenseSetup where CompanyID=" + Main.CompanyID + " AND CAST(ESName as varchar) like '%" + txt_Find.Text + "%'");

        }
        private void frm_ExpenseSetup_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select ESID,ESName,ESactive from ExpenseSetup where CompanyID=" + Main.CompanyID + "");
        }
        private void AllClear()
        {
            txt_Name.Text = String.Empty;
        }
        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
