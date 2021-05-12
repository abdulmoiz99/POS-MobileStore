using MobileShop.SetupForms;
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
    public partial class frm_AddItem : Form
    {
        int mode;
        string FName = "AddItem";
        public frm_AddItem()
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
        private void Showfrm(Form frm)
        {
            try
            {
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
            }
        }
        private void AllClear()
        {
            txt_Name.Text = string.Empty;
            txt_Find.Text = string.Empty;
            txt_Quantity.Text = string.Empty;
            txt_PurchasePrice.Text = string.Empty;
            txt_SalePrice.Text = string.Empty;

        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            AllClear();
            btn_edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_New.Enabled = false;
            cmb_Brand.Enabled = true;
            cmb_Type.Enabled = true;
            cmb_Unit.Enabled = true;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_Name.Enabled = true;
            txt_PurchasePrice.Enabled = true;
            txt_SalePrice.Enabled = true;
            txt_Quantity.Enabled = true;
            txt_Name.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_dgvRowId.Text != "")
            {
                mode = 2;
                btn_edit.Enabled = false;
                btn_New.Enabled = false;
                btn_Delete.Enabled = false;
                cmb_Brand.Enabled = true;
                cmb_Type.Enabled = true;
                cmb_Unit.Enabled = true;
                btn_Save.Enabled = true;
                btn_cancel.Enabled = true;
                txt_Name.Enabled = true;
                txt_PurchasePrice.Enabled = true;
                txt_SalePrice.Enabled = true;
                txt_Quantity.Enabled = true;
                txt_Name.Focus();
            }
            else MessageBox.Show("Please Select A record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            int active = 0;
            if (rdo_Yes.Checked == true)
            {
                active = 1;
            }
            if (cmb_Brand.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_Type.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_Unit.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Unit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Item Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Quantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PurchasePrice.Text == "")
            {
                MessageBox.Show("Please Enter Purchase Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_SalePrice.Text == "")
            {
                MessageBox.Show("Please Enter SalePrice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode == 1)// Save DAtA
                {

                    if (Rights.Add(Main.RDRMID, FName) == false)
                    {
                        MessageBox.Show("You donot have permision to add new item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (YesOrNo == DialogResult.Yes)
                        {

                            SQL.NonScalarQuery(@"Insert Into ItemMaster(IMName              ,IMITID                     ,IMIBID                        ,IMQty                                             ,IMPurchasePrice                                       ,IMSalesPrice                                      ,IMActive  ,CompanyID) 
                                                     VALUES('" + txt_Name.Text + "' , " + cmb_Type.SelectedValue + "," + cmb_Brand.SelectedValue + "," + float.Parse(txt_Quantity.Text.ToString()) + "," + float.Parse(txt_PurchasePrice.Text.ToString()) + "," + float.Parse(txt_SalePrice.Text.ToString()) + "," + active + "," + Main.CompanyID + ")");
                            AllClear();
                            frm_AddItem_Load(sender, e);
                            btn_cancel_Click(sender, e);
                            MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else if (mode == 2)//UPDATE RECORD
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
                            SQL.NonScalarQuery(@"UPDATE ITEMMASTER set IMName='" + txt_Name.Text + "', IMITID=" + cmb_Type.SelectedValue + ", IMIBID=" + cmb_Brand.SelectedValue + " ,IMQty=" + float.Parse(txt_Quantity.Text) + ",IMPurchasePrice=" + float.Parse(txt_PurchasePrice.Text) + "  ,IMSalesPrice=" + float.Parse(txt_SalePrice.Text) + " where IMID=" + int.Parse(txt_dgvRowId.Text) + "  ");
                            AllClear();
                            frm_AddItem_Load(sender, e);
                            btn_cancel_Click(sender, e);
                            MessageBox.Show("Record UPDATED Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
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
            cmb_Brand.Enabled = false;
            cmb_Type.Enabled = false;
            cmb_Unit.Enabled = false;
            txt_PurchasePrice.Enabled = false;
            txt_SalePrice.Enabled = false;
            txt_Quantity.Enabled = false;
        }

        private void btn_AddType_Click(object sender, EventArgs e)
        {
            var frm = new frm_TypeSetup();
            frm.ShowDialog();
        }
        private void btn_AddBrand_Click(object sender, EventArgs e)
        {
            var frm = new frm_BrandSetup();
            frm.ShowDialog();
        }
        private void frm_AddItem_Load(object sender, EventArgs e)
        {
            String BrandSetup = SQL.ScalarQuery("SELECT COUNT(IBName) FROM ItemBrand WHERE IBActive =1 and  CompanyID=" + Main.CompanyID + "");
            String TypeSetup = SQL.ScalarQuery("SELECT COUNT(ITName) FROM ItemType WHERE ITActive =1 and CompanyID=" + Main.CompanyID + "");
            String UnitSetup = SQL.ScalarQuery("SELECT COUNT(UName) FROM UnitSetup WHERE UActive =1 and CompanyID=" + Main.CompanyID + "");
            if (BrandSetup == "0")
            {
                MessageBox.Show("No Brand Is Found Please Enter Brand", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var frm = new frm_BrandSetup();
                Showfrm(frm);
            }
            else if (TypeSetup == "0")
            {
                MessageBox.Show("No Type Is Found Please Enter Type", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var frm = new frm_TypeSetup();
                Showfrm(frm);
            }
            else if (UnitSetup == "0")
            {
                MessageBox.Show("No Unit Is Found Please Enter Unit", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var frm = new frm_UnitSetup();
                Showfrm(frm);
            }
            else
            {
                Main.fillCombo(cmb_Brand, "ItemBrand", "IBName", "IBID", "IBActive=1");
                Main.fillCombo(cmb_Type, "ItemType", "ITName", "ITID", "ITActive=1");
                Main.fillCombo(cmb_Unit, "UnitSetup", "UName", "UID", "UActive=1");
                Main.fillDgv(dgv_BrandSetup, "select IMID,IMName,ITID,ITName,IBID,IBName,IMQty,IMPurchasePrice,IMSalesPrice,IMActive from TvuItemMAster where CompanyID=" + Main.CompanyID + "");
            }
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
                    txt_dgvRowId.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_BrandSetup.Rows[index];
                    txt_dgvRowId.Text = selectedrow.Cells[0].Value.ToString();
                    txt_Name.Text = selectedrow.Cells["IMNAme"].Value.ToString();
                    txt_Quantity.Text = selectedrow.Cells["IMQty"].Value.ToString();
                    txt_PurchasePrice.Text = selectedrow.Cells["IMPurchasePrice"].Value.ToString();
                    txt_SalePrice.Text = selectedrow.Cells["IMSalesPrice"].Value.ToString();
                    cmb_Brand.SelectedIndex = int.Parse(selectedrow.Cells["IBID"].Value.ToString());
                    cmb_Type.SelectedIndex = int.Parse(selectedrow.Cells["ITID"].Value.ToString());

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
        private void btn_AddUnit_Click(object sender, EventArgs e)
        {
            var frm = new frm_UnitSetup();
            frm.ShowDialog();
        }
        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_BrandSetup, "select IMID,IMName,IBName,IMQty,IMPurchasePrice,IMSalesPrice,IBId,ITId,IMActive from TvuItemMaster where CompanyID=" + Main.CompanyID + " AND CAST(IMName as varchar) + CAST(IBName as varchar) like '%" + txt_Find.Text + "%'");
        }
        private void txt_PurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
        private void txt_SalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
    }
}
