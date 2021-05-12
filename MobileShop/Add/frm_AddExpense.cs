using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShop.SetupForms;

namespace MobileShop
{
    public partial class frm_AddExpense : Form
    {
        int mode;
        String FName = "AddExpense";
        public frm_AddExpense()
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
        private void AllClear()
        {
            txt_Description.Text = "";
            txt_Amount.Text = "";
            cmb_ExpenseTitle.SelectedIndex = 0;
        }
        private void btn_AddType_Click(object sender, EventArgs e)
        {
            var frm = new frm_ExpenseSetup();
            frm.ShowDialog();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            //AllClear();
            btn_edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_Amount.Enabled = true;
            txt_Description.Enabled = true;
            datetimePicker.Enabled = true;
            cmb_ExpenseTitle.Enabled = true;
            dgv_BrandSetup.Enabled = false;
            txt_Amount.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            float amount;
            if (cmb_ExpenseTitle.SelectedIndex<0)
            {
                MessageBox.Show("Please Select Expense Title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Amount.Text, out amount))
            {
                MessageBox.Show("Please Enter Correct Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {
                if (Rights.Add(Main.RDRMID, FName) == false)
                {
                    MessageBox.Show("You donot have permision to add new item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txt_Amount.Text == "")
                {
                    MessageBox.Show("Please Enter Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_Description.Text == "")
                {
                    MessageBox.Show("Please Enter Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery("Insert Into Expenses(EESID,EAmount,EDescription,EDate,CompanyID) values ('" + cmb_ExpenseTitle.SelectedValue + "'," + amount + ",'" + txt_Description.Text + "','" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "'," + Main.CompanyID + ")");
                        AllClear();
                        btn_cancel_Click(sender, e);
                        MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else if (mode == 2)
            {
                int id;
                if (Rights.Edit(Main.RDRMID, FName) == false)
                {
                    MessageBox.Show("You donot have permision to edit item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!int.TryParse(txt_DataGridViewIndex.Text, out id))
                {
                    MessageBox.Show("Invalid Row Selected ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure To UPDATE the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        SQL.NonScalarQuery(@"update Expenses set EESID=" + cmb_ExpenseTitle.SelectedValue + ",EAmount=" + amount + " where EID=" + id + "");
                        AllClear();
                        btn_cancel_Click(sender, e);
                        MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_edit.Enabled = true;
            btn_Delete.Enabled = false;
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_Amount.Enabled = false;
            txt_Description.Enabled = false;
            datetimePicker.Enabled = false;
            cmb_ExpenseTitle.Enabled = false;
            dgv_BrandSetup.Enabled = false;


        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_Amount.Enabled = true;
            txt_Description.Enabled = true;
            datetimePicker.Enabled = true;
            cmb_ExpenseTitle.Enabled = true;
            dgv_BrandSetup.Enabled = true;
            txt_Amount.Focus();
        }
        private void frm_AddExpense_Activated(object sender, EventArgs e)
        {

        }
        private void frm_AddExpense_Load(object sender, EventArgs e)
        {
            try
            {
                String ExpenseSetup = SQL.ScalarQuery("SELECT COUNT(ESName) FROM  ExpenseSetup WHERE ESActive =1 and CompanyID=" + Main.CompanyID + "");
                if (ExpenseSetup == "0")
                {
                    MessageBox.Show("No Expense type Is Found Please Enter Expense Name ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_ExpenseSetup();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    Main.fillCombo(cmb_ExpenseTitle, "ExpenseSetup", "ESName", "ESID", "ESActive=1");
                    Main.fillDgv(dgv_BrandSetup, "Select EID,EESID,ESName,EAmount,EDescription,EDate from TvuExpenses");
                }
            }
            catch (Exception)
            {
            }
        }
        private void dgv_BrandSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AllClear();
                int index = e.RowIndex;
            if (index > -1)
            {
                txt_DataGridViewIndex.Text = index.ToString();
                DataGridViewRow selectedrow = dgv_BrandSetup.Rows[index];
                txt_DataGridViewIndex.Text = selectedrow.Cells["EID"].Value.ToString();
                txt_Amount.Text = selectedrow.Cells["Amount"].Value.ToString();
                txt_Description.Text = selectedrow.Cells["Description"].Value.ToString();
                cmb_ExpenseTitle.SelectedIndex = int.Parse(selectedrow.Cells["EESID"].Value.ToString()) - 1;
            }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Rights.Delete(Main.RDRMID, FName) == true)
            {
            }
            else MessageBox.Show("You donot have permision to delete item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select ESName,EAmount,Edescription,EDate from TvuExpenses where CompanyID=" + Main.CompanyID + " AND CAST(ESName as varchar) like '%" + txt_Find.Text + "%'");
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {

            Main.OnlyDigits(e);
        }
    }
}
