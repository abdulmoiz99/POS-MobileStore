using CrystalDecisions.CrystalReports.Engine;
using MobileShop.SetupForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.TransictionsForms
{
    public partial class frm_PurchaseInvoices : Form
    {
        int mode;
        int intPMNoo;
        float amount = 0;
        String TMode;
        bool save = false;
        //Functions Start 
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
        private void Report(int PMID)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                Cursor = Cursors.WaitCursor;
                ReportDocument myReport = new ReportDocument();
                string reportPath = (Application.StartupPath + @"\Reports\PurchaseOrder.rpt");
                var ds = new DataSet();
                String SqlQuery = "select * from TvuPurchaseOrder where PDPMID=" + PMID + "";
                var adapter = new SqlDataAdapter(SqlQuery, SQL.Con);
                adapter.Fill(ds, "TvuPurchaseOrder");
                myReport.Load(reportPath);
                myReport.SetDataSource(ds);
                var frm = new myReportForm();
                frm.crystalReportViewer2.ReportSource = myReport;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQL.Con.Close();
                Cursor = Cursors.Default;
            }
        }
        private void GetTransactionType(int ID)
        {
            String Type = SQL.ScalarQuery("Select PMMode from PurchaseMaster where PMID=" + ID + "");
            if (String.Compare(Type, "CASH") == 0)
            {
                rdo_Cash.Checked = true;
            }
            else rdo_Credit.Checked = true;
        }
        private String GetTotalItem()
        {
            float sum = 0;
            for (int i = 0; i < dgv_PurchaseDetail.Rows.Count; i++)
            {
                String SUM = dgv_PurchaseDetail.Rows[i].Cells["PDQty"].Value.ToString();
                sum += float.Parse(SUM);
            }
            return sum.ToString();
        }
        private String GetTotalAmount()
        {
            float sum = 0;
            for (int i = 0; i < dgv_PurchaseDetail.Rows.Count; ++i)
            {
                String SUM = dgv_PurchaseDetail.Rows[i].Cells["PDAmount"].Value.ToString();
                sum += float.Parse(SUM);
            }
            return sum.ToString();
        }
        public void GenerateInvoiceNo()
        {
            try
            {
                String DocNo = SQL.ScalarQuery("Select DocNo from DocType where DocType='Purchase' and CompanyId=" + Main.CompanyID + "");
                txt_InvoiceNo.Text = DocNo;
                string Compare = "";
                Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM PurchaseMaster  WHERE PMDocId =" + cmb_InvoiceType.SelectedValue + " ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
                if (string.Compare("True", Compare) == 0)
                {
                    String PMNoo = SQL.ScalarQuery("Select PMNoo from PurchaseMaster where PMId=(SELECT MAX(PMId) FROM PurchaseMaster)");
                    if (PMNoo != "")
                    {
                        intPMNoo = int.Parse(PMNoo) + 1;
                        txt_InvoiceNo.Text += intPMNoo.ToString();
                    }
                }
                else
                {
                    String PMNoo = SQL.ScalarQuery("select DocStartFrom from DocType where DocId=" + cmb_InvoiceType.SelectedValue + " ");
                    if (PMNoo != "")
                    {
                        intPMNoo = int.Parse(PMNoo);
                        txt_InvoiceNo.Text += intPMNoo.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("123" + ex.Message);
            }
        }
        public void PurchaseInfoClear()
        {
            try
            {
                cmb_ItemName.SelectedIndex = 0;
                cmb_PIColor.SelectedIndex = 0;
                cmb_PIBrand.SelectedIndex = 0;
                cmb_PIType.SelectedIndex = 0;
                txt_PIUnitPrice.Text = "";
                txt_PIQuantity.Text = "";
                txt_PIAmount.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void FormClear()
        {
            try
            {
                PurchaseInfoClear();
                txt_CIName.Text = string.Empty;
                txt_CICellNo.Text = string.Empty;
                txt_CIRemarks.Text = string.Empty;
                dgv_PurchaseDetail.Rows.Clear();
                //foreach (DataGridViewRow item in this.dgv_PurchaseDetail.Rows)
                //{
                //    dgv_PurchaseDetail.Rows.RemoveAt(item.Index);
                //}
            }
            catch (Exception)
            {
            }
        }
        private void GetDetails(int ID)
        {
            try
            {
                var cmd = new SqlCommand("select PDID,PMID,PDUID,PMID,PDIMID,PDICID,ICName,IMName,PDIBID,IBName,PDITID,ITName,PDQty,PDRate,PDAmount,UName from TvuPurchaseDetail where PMid=" + ID + "", SQL.Con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                for (int s = 0; s <= tbl.Rows.Count - 1; s++)
                {

                    var item = tbl.Rows[s];
                    // dgv_PurchaseDetail.Rows.Add("", "", cmb_ItemName.SelectedValue, cmb_ItemName.Text, cmb_PIColor.SelectedValue, cmb_PIColor.Text, cmb_PIBrand.SelectedValue, cmb_PIBrand.Text, cmb_PIType.SelectedValue, cmb_PIType.Text, txt_PIQuantity.Text, cmb_PIUnit.SelectedValue, cmb_PIUnit.Text, txt_PIUnitPrice.Text, txt_PIAmount.Text);
                    dgv_PurchaseDetail.Rows.Add(item["PDID"], item["PMID"], item["PDIMID"], item["IMName"], item["PDICID"], item["ICName"], item["PDIBID"], item["IBName"], item["PDITID"], item["ITName"], item["PDQty"], item["PDUID"], item["UName"], item["PDRate"], item["PDAmount"]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getData()
        {
            txt_PIUnitPrice.Text = "";
            String Result = SQL.ScalarQuery("select IMSalesPrice from ItemMaster where IMID=1");// + int.Parse(cmb_ItemName.SelectedValue.ToString()) + "");
            txt_PIUnitPrice.Text = Result;
        }
        private void enable_disable(bool value)
        {
            txt_CICellNo.Enabled = value;
            txt_CIName.Enabled = value;
            txt_CIRemarks.Enabled = value;
            txt_PIQuantity.Enabled = value;
            txt_PIUnitPrice.Enabled = value;
            txt_PuchaseMasterID.Enabled = value;
            btnAdd.Enabled = value;
            btn_Remove.Enabled = value;
            btn_Update.Enabled = value;
            cmb_ItemName.Enabled = value;
            cmb_PIBrand.Enabled = value;
            cmb_PIColor.Enabled = value;
            cmb_PIType.Enabled = value;
            cmb_PIType.Enabled = value;
            dtp_dueDate.Enabled = value;
            rdo_Cash.Enabled = value;
            rdo_Credit.Enabled = value;
            btn_Save.Enabled = value;
            btn_cancel.Enabled = value;
            btn_Delete.Enabled = value;
            btn_Update.Enabled = value;
            cmb_InvoiceType.Enabled = value;
            btn_Print.Enabled = value;
            dgv_PurchaseDetail.Enabled = value;
        }
        private void UpdatePurchaseInvoice()
        {
            SQL.Con.Open();
            using (SqlTransaction trans = SQL.Con.BeginTransaction())
            {
                try
                {
                    int PMID;
                    int.TryParse(txt_PuchaseMasterID.Text, out PMID);
                    SQL.NonScalarQueryTransaction(@"Update PUrchaseMAster set " +
                                         "PMCustomerNAme='" + txt_CIName.Text + "', " +
                                         "PMCustomerCell='" + txt_CICellNo.Text + "', " +
                                         "PMRemarks = '" + txt_CIRemarks.Text + "', " +
                                         "PMDate =  '" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "', " +
                                         "PMMode = '" + TMode + "', " +
                                         "PMTQuantity=" + float.Parse(lab_TQuantity.Text.ToString()) + ", " +
                                         "PMTAmount = " + float.Parse(lab_TAmount.Text.ToString()) + " where PMID =" + PMID + "", trans);
                    for (int i = 0; i < dgv_PurchaseDetail.Rows.Count; i++)
                    {
                        //String ItemName = dgv_PurchaseDetail.Rows[i].Cells["ItemName"].Value.ToString();
                        int ItemID = int.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDIMID"].Value.ToString());
                        int ColId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDICId"].Value);
                        int BrandId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDIBId"].Value);
                        int TypeId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDITId"].Value);
                        int UnitId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDUId"].Value);
                        float Quantity = float.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDQty"].Value.ToString());
                        float Rate = float.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDRate"].Value.ToString());
                        float Amount = float.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDAmount"].Value.ToString());
                        SQL.NonScalarQueryTransaction("UPdate PurchaseDetail set  " +
                            "PDIMID = " + ItemID + ", " +
                            "PDICID = " + ColId + ", " +
                            "PDIBID = " + BrandId + " , " +
                            "PDITID = " + TypeId + " , " +
                            //  "PDUID  = " + UnitId + ", " + 
                            "PDQty  = " + Quantity + ", " +
                          "PDAmount = " + Amount + " , " +
                            "PDRate = " + Rate + "", trans);
                    }
                    save = true;
                    if (rdo_Credit.Checked == true)
                    {
                        SQL.NonScalarQueryTransaction(@"Update CashFlow set " +
                                                        "CFDate = '" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "', " +
                                                        "CFAmt=" + decimal.Parse(lab_TAmount.Text) + "", trans);
                    }
                    MessageBox.Show("Record Saved Successfully");
                    FormClear();
                    dgv_PurchaseDetail.Enabled = true;
                    GetDetails(PMID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // trans.Rollback();
                }
                finally
                {
                    SQL.Con.Close();
                }
                btn_Print.Enabled = true;
            }
        }
        private void InsertPurchaseInvoice()
        {
            if (SQL.Con.State == ConnectionState.Open)
            {
                SQL.Con.Close();
            }
            SQL.Con.Open();
            using (SqlTransaction trans = SQL.Con.BeginTransaction())
            {
                try
                {
                    SQL.NonScalarQueryTransaction(@"Insert into PurchaseMaster(PMDocID                              ,PMNo                        ,PMNoo            ,PMDate                                                  ,PMCustomerName           ,   PMCustomerCell          ,PMRemarks                    ,PMTQuantity                              ,PMTAmount               ,PMMode      ,PMDueDate                                                   ,CompanyId              )
                                                     values(" + cmb_InvoiceType.SelectedValue + ",'" + txt_InvoiceNo.Text + "', " + intPMNoo + ",'" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "','" + txt_CIName.Text + "','" + txt_CICellNo.Text + "','" + txt_CIRemarks.Text + "' ," + float.Parse(lab_TQuantity.Text) + "," + float.Parse(lab_TAmount.Text) + " ,'" + TMode + "','" + dtp_dueDate.Value.Date.ToString("yyyyMMdd") + "'," + Main.CompanyID + ")  ", trans);
                    txt_PuchaseMasterID.Text = SQL.ScalarQuery("Select PMID from PurchaseMaster where PMNoo =" + intPMNoo + "And CompanyId =" + Main.CompanyID + "");
                    int PMID;
                    int.TryParse(txt_PuchaseMasterID.Text, out PMID);
                    for (int i = 0; i < dgv_PurchaseDetail.Rows.Count; i++)
                    {
                        int ItemID = int.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDIMID"].Value.ToString());
                        int ColId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDICId"].Value);
                        int BrandId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDIBId"].Value);
                        int TypeId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDITId"].Value);
                        int UnitId = Convert.ToInt32(dgv_PurchaseDetail.Rows[i].Cells["PDUId"].Value);
                        float Quantity = float.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDQty"].Value.ToString());
                        float Rate = float.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDRate"].Value.ToString());
                        float Amount = float.Parse(dgv_PurchaseDetail.Rows[i].Cells["PDAmount"].Value.ToString());
                        SQL.NonScalarQueryTransaction(@"Insert into PurchaseDetail(      PDPMID         ,  PDIMID        ,PDICID          ,PDIBID        ,PDITID          ,PDUID           ,PDQty          ,PDRate       ,PDAmount,CompanyID)
                                                                            values (" + int.Parse(txt_PuchaseMasterID.Text) + " ,'" + ItemID + "'," + ColId + " ," + BrandId + ", " + TypeId + " ," + UnitId + "  ," + Quantity + "," + Rate + "," + Amount + "                  ," + Main.CompanyID + ")", trans);
                    }
                    save = true;
                    if (rdo_Credit.Checked == true)
                    {
                        SQL.NonScalarQueryTransaction(@"Insert Into CashFlow (CFDate                                                  ,CFInvID     ,CFMode,CFAmt)
                                                               Values('" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "' ," + PMID + ",'PAYABLE'," + decimal.Parse(lab_TAmount.Text) + ")", trans);
                    }
                    MessageBox.Show("Record Saved Successfully");
                    //frm_PurchaseInvoices_Load(sender, e);
                    FormClear();
                    dgv_PurchaseDetail.Enabled = true;
                    GetDetails(PMID);
                    //Main.fillDgv(dgv_PurchaseDetail, "select PDID,PMID,ICName,IMName,IBName,ITName,PDQty,PDRate,PDAmount,UName from TvuPurchaseDetail where PMid=" + PMID + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // trans.Rollback();
                }
                finally
                {
                    SQL.Con.Close();
                }
                btn_Print.Enabled = true;
            }
        }
        private void UpdateInvoice(int row)
        {
            try
            {
                dgv_PurchaseDetail.Rows[row].Cells["PDID"].Value = "";
                dgv_PurchaseDetail.Rows[row].Cells["PDPMID"].Value = "";
                dgv_PurchaseDetail.Rows[row].Cells["PDIMID"].Value = cmb_ItemName.SelectedValue;
                dgv_PurchaseDetail.Rows[row].Cells["PDIMName"].Value = cmb_ItemName.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDICId"].Value = cmb_PIColor.SelectedValue;
                dgv_PurchaseDetail.Rows[row].Cells["Colour"].Value = cmb_PIColor.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDIBID"].Value = cmb_PIBrand.SelectedValue;
                dgv_PurchaseDetail.Rows[row].Cells["Brand"].Value = cmb_PIBrand.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDITID"].Value = cmb_PIType.SelectedValue;
                dgv_PurchaseDetail.Rows[row].Cells["Type"].Value = cmb_PIType.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDQty"].Value = txt_PIQuantity.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDUId"].Value = cmb_PIUnit.SelectedValue;
                dgv_PurchaseDetail.Rows[row].Cells["UnitAbr"].Value = cmb_PIUnit.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDRate"].Value = txt_PIUnitPrice.Text;
                dgv_PurchaseDetail.Rows[row].Cells["PDAmount"].Value = txt_PIAmount.Text;
                dgv_PurchaseDetail.Rows[row].Cells["rowid"].Value = row;
                dgv_PurchaseDetail.Refresh();
                PurchaseInfoClear();
                MessageBox.Show("Record UPDATED successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool LoadData()
        {
            try
            {
                String ItemMaster = SQL.ScalarQuery("SELECT COUNT(IMName) FROM ItemMaster WHERE CompanyID=" + Main.CompanyID + "");
                String ItemBrand = SQL.ScalarQuery("SELECT COUNT(IBName) FROM ItemBrand WHERE CompanyID=" + Main.CompanyID + "");
                String ItemColor = SQL.ScalarQuery("SELECT COUNT(ICName) FROM ItemColor WHERE CompanyID=" + Main.CompanyID + "");
                String ItemType = SQL.ScalarQuery("SELECT COUNT(ITName) FROM ItemType WHERE CompanyID=" + Main.CompanyID + "");
                String DocType = SQL.ScalarQuery("SELECT COUNT(DOCid) FROM DocType where  CompanyID=" + Main.CompanyID + " and DocType='Purchase'");
                String UnitSetup = SQL.ScalarQuery("SELECT COUNT(UName) FROM UnitSetup WHERE CompanyID=" + Main.CompanyID + "");
                if (ItemBrand == "0")
                {
                    MessageBox.Show("No Item Brand Is Found Please Enter Item Brand", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_BrandSetup();
                    Showfrm(frm);
                }
                else if (ItemColor == "0")
                {
                    MessageBox.Show("No Item Color Is Found Please Enter Item Color", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_ColorSetup();
                    Showfrm(frm);
                }
                else if (ItemType == "0")
                {
                    MessageBox.Show("No Item Type Is Found Please Enter Item Type", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_TypeSetup();
                    Showfrm(frm);
                }
                else if (DocType == "0")
                {
                    MessageBox.Show("No Doc Type Is Found Please Enter Doc Type", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_DocSetup();
                    Showfrm(frm);
                }
                else if (UnitSetup == "0")
                {
                    MessageBox.Show("No Unit Is Found Please Enter Unit", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_UnitSetup();
                    Showfrm(frm);
                }
                else if (ItemMaster == "0")
                {
                    MessageBox.Show("No Item Name Is Found Please Enter Item Name", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var frm = new frm_AddItem();
                    Showfrm(frm);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Function End
        public frm_PurchaseInvoices()
        {
            InitializeComponent();
        }
        private void frm_PurchaseInvoices_Load(object sender, EventArgs e)
        {
            if (LoadData() == false)
            {

            }
            else
            {
                //Item Name
                //Main.fillCombo(cmb_ItemName, "ItemMaster", "IMName", "IMID", "IMActive=1");
                Main.fillCombo(cmb_ItemName, "ItemMaster", "IMName", "IMID", "IMActive=1");
                //Item Brand
                Main.fillCombo(cmb_PIBrand, "ItemBrand", "IBName", "IBID", "IBActive=1");
                //Item Color
                Main.fillCombo(cmb_PIColor, "ItemColor", "ICName", "ICID", "ICActive=1");
                //Item Type
                Main.fillCombo(cmb_PIType, "ItemType", "ITName", "ITID", "ITActive=1");
                //Invoice Type
                Main.fillCombo(cmb_InvoiceType, "DocType", "DocType", "DocID", "DocType='Purchase'");
                //Unit Setup
                Main.fillCombo(cmb_PIUnit, "UnitSetup", "UName", "UID", "UActive=1");
                GenerateInvoiceNo();
                ////setup 
                lab_TAmount.Text = "0";
                lab_TQuantity.Text = "0";
                txt_PIUnitPrice.Text = "";
                enable_disable(false);
                btn_New.Enabled = true;
                btn_Remove.Enabled = false;
            }
        }
        private void EfDTxtPDQty_TextChanged(object sender, EventArgs e)
        {
            EfDtxtPDRate_TextChanged(sender, e);
        }
        private void EfDtxtPDRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Qty = txt_PIQuantity.Text;
                float quantity = 0;
                if (float.TryParse(Qty, out quantity))
                {
                    txt_PIQuantity.Text = quantity.ToString();
                }
                string UPrice = txt_PIUnitPrice.Text;
                float UnitPrice = 0;
                if (float.TryParse(UPrice, out UnitPrice))
                {
                    txt_PIUnitPrice.Text = UnitPrice.ToString();
                }
                amount = quantity * UnitPrice;
                txt_PIAmount.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btn_Remove.Enabled = false;
            if (cmb_ItemName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Item Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_PIBrand.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Item Brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_PIColor.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Item color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PIQuantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PIUnitPrice.Text == "")
            {
                MessageBox.Show("Please Enter UnitPrice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int row = dgv_PurchaseDetail.RowCount;
                //////-------------------------PDID,PMNO itemID     ItemName 
                float Quantity;
                float PricePerUnit;
                if (!float.TryParse(txt_PIQuantity.Text, out Quantity))
                {
                    MessageBox.Show("Invalid Quantity Please Check Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!float.TryParse(txt_PIUnitPrice.Text, out PricePerUnit))
                {
                    MessageBox.Show("Invalid Price  Please Check Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {

                        Quantity = float.Parse(txt_PIQuantity.Text);
                        PricePerUnit = float.Parse(txt_PIAmount.Text);
                        dgv_PurchaseDetail.Rows.Add("", "", cmb_ItemName.SelectedValue, cmb_ItemName.Text, cmb_PIColor.SelectedValue, cmb_PIColor.Text, cmb_PIBrand.SelectedValue, cmb_PIBrand.Text, cmb_PIType.SelectedValue, cmb_PIType.Text, txt_PIQuantity.Text, cmb_PIUnit.SelectedValue, cmb_PIUnit.Text, txt_PIUnitPrice.Text, txt_PIAmount.Text);
                        lab_TQuantity.Text = GetTotalItem();
                        lab_TAmount.Text = GetTotalAmount();
                        PurchaseInfoClear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dgv_PurchaseDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dgv_PurchaseDetail.Rows[index];
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (save == false)
                {
                    MessageBox.Show("Record Not Save Yet, Please Save The Record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int IMEI_PDID = int.Parse(selectedrow.Cells["PDID"].Value.ToString());
                    int IMEI_PMID = int.Parse(selectedrow.Cells["PDPMID"].Value.ToString());
                    string IMEI_ItemNAme = selectedrow.Cells["PDIMName"].Value.ToString();
                    float IMEI_Quantity = float.Parse(selectedrow.Cells["PDQty"].Value.ToString());
                    var frm = new frm_IMEI(IMEI_PMID, IMEI_PDID, IMEI_Quantity, IMEI_ItemNAme, 1);
                    frm.ShowDialog();

                }
            }
            if (save == false)
            {
                try
                {
                    PurchaseInfoClear();
                    if (index > -1)
                    {
                        txt_rowid.Text = index.ToString();
                        cmb_ItemName.SelectedIndex = int.Parse(selectedrow.Cells["PDIMID"].Value.ToString()) - 1;
                        txt_PIQuantity.Text = selectedrow.Cells["PDQty"].Value.ToString();
                        txt_PIUnitPrice.Text = selectedrow.Cells["PDRate"].Value.ToString();
                        txt_PIAmount.Text = selectedrow.Cells["PDAmount"].Value.ToString();
                        cmb_PIColor.SelectedIndex = int.Parse(selectedrow.Cells["PDICId"].Value.ToString()) - 1;
                        cmb_PIBrand.SelectedIndex = int.Parse(selectedrow.Cells["PDIBId"].Value.ToString()) - 1;
                        cmb_PIType.SelectedIndex = int.Parse(selectedrow.Cells["PDITId"].Value.ToString()) - 1;
                        btn_Remove.Enabled = true;
                        //mode = 1;
                    }
                    index = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_rowid.Text != "")
                {
                    int index = int.Parse(txt_rowid.Text);
                    foreach (DataGridViewRow item in this.dgv_PurchaseDetail.SelectedRows)
                    {
                        dgv_PurchaseDetail.Rows.RemoveAt(item.Index);
                    }
                    lab_TAmount.Text = GetTotalAmount();
                    lab_TQuantity.Text = GetTotalItem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmb_ItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///to get record   
            getData();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rdo_Cash.Checked == true)
            {
                TMode = "CASH";
            }
            else
            {
                TMode = "CREDIT";
            }


            if (txt_CIName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txt_CICellNo.Text == "")
            {
                MessageBox.Show("Please Enter Customer Contact No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (dgv_PurchaseDetail.RowCount < 1)
            {
                MessageBox.Show("No Item Avaiable In Cart", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (mode == 1)
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Insert The Current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    InsertPurchaseInvoice();
                    btn_Save.Enabled = false;
                }
            }
            else if (mode == 2)
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Update The Current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    UpdatePurchaseInvoice();
                    btn_Save.Enabled = false;

                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (mode != 1)
            {
                mode = 2;
                save = false;
                enable_disable(true);
            }

        }
        private void rdo_Credit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Credit.Checked == true)
            {
                dtp_dueDate.Enabled = true;
            }
            else dtp_dueDate.Enabled = false;
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            FormClear();
            GenerateInvoiceNo();
            enable_disable(true);
            pnl_find.Visible = false;
            btnfnd.Enabled = false;
            btn_New.Enabled = false;
            lab_TAmount.Text = "0";
            lab_TQuantity.Text = "0";
            save = false;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            enable_disable(false);
            btnfnd.Enabled = true;
            FormClear();
            pnl_find.Visible = false;
            btnfnd.Enabled = true;
            btn_New.Enabled = true;

        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            int PMID;
            if (save == false)
            {
                MessageBox.Show("Please Save Order First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txt_PuchaseMasterID.Text, out PMID))
            {
                MessageBox.Show("An unkown error occour during excecution1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_PuchaseMasterID.Text == "")
            {
                MessageBox.Show("An unkown error occour during excecution2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Report(PMID);
            }
        }
        private void txt_PIQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
        private void txt_PIUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnfnd_Click(object sender, EventArgs e)
        {
            pnl_find.Visible = true;
            Main.fillDgv(dgv_find, "select PMID,PMNo,PMDAte,PMCustomerName,PMCustomerCell,PMRemarks,PMTQuantity,PMTAmount,PMMode from PurchaseMaster ");
        }
        private void dgv_find_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mode = 2;
            pnl_find.Visible = false;
            btn_Save.Enabled = false;
            btn_Print.Enabled = false;
            btn_Update.Enabled = true;
            btn_Print.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            try
            {
                int index = e.RowIndex;

                FormClear();
                string Date = "";
                DataGridViewRow selectedrow = dgv_find.Rows[index];
                if (index > -1)
                {
                    //purchase Detaild
                    txt_rowid.Text = index.ToString();
                    txt_PuchaseMasterID.Text = selectedrow.Cells["PMID1"].Value.ToString();
                    //purcahse Master
                    txt_CIName.Text = selectedrow.Cells["Name"].Value.ToString();
                    txt_CICellNo.Text = selectedrow.Cells["CellNo"].Value.ToString();
                    Date = selectedrow.Cells["Date"].Value.ToString();
                    // txt_CIRemarks.Text = selectedrow.Cells["Remarks"].Value.ToString();
                    dgv_PurchaseDetail.Enabled = true;
                    btn_Remove.Enabled = true;
                }
                index = 0;
                int ID = 0;
                if (int.TryParse(txt_PuchaseMasterID.Text, out ID))
                {
                    GetDetails(ID);
                }
                txt_InvoiceNo.Text = SQL.ScalarQuery("Select PMNo from PurchaseMaster where PMID=" + ID + " ");
                GetTransactionType(ID);
                lab_TQuantity.Text = GetTotalItem();
                lab_TAmount.Text = GetTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_find, "  select PMID,PMNo,PMDAte,PMCustomerName,PMCustomerCell,PMRemarks,PMTQuantity,PMTAmount,PMMode from PurchaseMaster where  CAST(PMNo  as varchar)+ CAST (PMCustomerName as varchar) like '%" + txt_Find.Text + "%'");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateRow_Click(object sender, EventArgs e)
        {
            int row;
            if (txt_rowid.Text == "")
            {
                MessageBox.Show("Please Select A Record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PIQuantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PIUnitPrice.Text == "")
            {
                MessageBox.Show("Please Enter Unit Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (int.TryParse(txt_rowid.Text, out row))
                {
                    UpdateInvoice(row);
                }
            }
            txt_rowid.Text = "";
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}


