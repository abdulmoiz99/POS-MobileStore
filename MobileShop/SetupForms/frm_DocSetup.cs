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
    public partial class frm_DocSetup : Form
    {
        int mode;
        public frm_DocSetup()
        {
            InitializeComponent();
        }
        public frm_DocSetup(bool close)
        {
            InitializeComponent();
            if (Main.CheckFormRights() == false)
            {
                this.Close();
                MessageBox.Show("Please login with administrator privileges and try agian ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Function Start 
        private void AllClear()
        {
            txt_VoucherType.Text = string.Empty;
            txt_VoucherNo.Text = string.Empty;
            txt_Abbr.Text = string.Empty;
            txt_DocStartFrom.Text = string.Empty;
            txt_Find.Text = string.Empty;

        }
        //Function End
        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            AllClear();
            dgv_DocSetup.Enabled = false;
            btn_edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_VoucherType.Enabled = true;
            txt_Abbr.Enabled = true;
            txt_VoucherNo.Enabled = true;
            txt_DocStartFrom.Enabled = true;
            txt_VoucherType.Focus();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            dgv_DocSetup.Enabled = true;
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_VoucherType.Enabled = true;
            txt_Abbr.Enabled = true;
            txt_VoucherNo.Enabled = true;
            txt_DocStartFrom.Enabled = true;
            txt_VoucherType.Focus();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //SQL.NonScalarQuery(@"Insert Into DocType (DocType,DocAbr,DocNo,DocStartFrom,CompanyID)
            //                                    values('"+txt_VoucherType.Text+ "','"+txt_Abbr.Text+ "','"+txt_VoucherNo.Text+"',)  ")
            if (txt_VoucherType.Text == "")
            {
                MessageBox.Show("Please Enter Voucher Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_Abbr.Text == "")
            {
                MessageBox.Show("Please Enter Abbrivation ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_VoucherNo.Text == "")
            {
                MessageBox.Show("Please Enter Voucher No ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_DocStartFrom.Text == "")
            {
                MessageBox.Show("Please Enter Voucher Start From", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int DocStartFrom = 0;
                if (mode == 1)
                {
                    if (int.TryParse(txt_DocStartFrom.Text, out DocStartFrom))
                    {

                        SQL.NonScalarQuery(@"Insert Into DocType (     DocType                  ,        DocAbr         ,     DocNo                  ,    DocStartFrom             ,CompanyID)
                                               values('" + txt_VoucherType.Text + "','" + txt_Abbr.Text + "','" + txt_VoucherNo.Text + "'," + DocStartFrom + "," + Main.CompanyID + ")");
                        MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        AllClear();
                        btn_cancel_Click(sender, e);
                        frm_DocSetup_Load(sender, e);
                       
                    }
                }
                else if (mode == 2)
                {
                    int index;
                    if (int.TryParse(txt_DataGridViewIndex.Text, out index))
                    {
                        SQL.NonScalarQuery("UPDATE DocType Set Doctype = '" + txt_VoucherType.Text + "', DocAbr='" + txt_Abbr.Text + "' ,DocNo='" + txt_VoucherNo.Text + "',DocStartFrom=" + DocStartFrom + " where CompanyID=" + Main.CompanyID + " AND DocID=" + index + " ");

                        MessageBox.Show("Record UPDATED Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        AllClear();
                    }
                    else MessageBox.Show("Please Select A record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    btn_cancel_Click(sender, e);
                }

            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            AllClear();
            mode = 0;
            dgv_DocSetup.Enabled = false;
            btn_edit.Enabled = true;
            btn_Delete.Enabled = false;
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_VoucherType.Enabled = false;
            txt_Abbr.Enabled = false;
            txt_VoucherNo.Enabled = false;
            txt_DocStartFrom.Enabled = false;
        }
        private void frm_DocSetup_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_DocSetup, "Select * from DocType");
        }
        private void dgv_DocSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AllClear();
                int index = e.RowIndex;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_DocSetup.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells["DOcID"].Value.ToString();
                    txt_VoucherType.Text = selectedrow.Cells["DocType"].Value.ToString();
                    txt_VoucherNo.Text = selectedrow.Cells["VoucherNo"].Value.ToString();
                    txt_Abbr.Text = selectedrow.Cells["Abr"].Value.ToString();
                    txt_DocStartFrom.Text = selectedrow.Cells["StartFrom"].Value.ToString();

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
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_DocSetup, "select DocType ,DocAbr,DocNo,DocStartFrom,DocID from DocType where CompanyID=1 AND CAST(DocType as varchar) + CAST(DocAbr as varchar) like '%"+txt_Find.Text+"%'");
        }
        private void txt_DocStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
    }
}
