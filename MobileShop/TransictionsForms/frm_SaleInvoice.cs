using CrystalDecisions.CrystalReports.Engine;
using MobileShop.SetupForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.TransictionsForms
{
    public partial class frm_SaleInvoice : Form
    {
        int mode;
        //  int intSDNoo;
        int intSMNoo;
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
        private void GetTransactionType(int ID)
        {
            String Type = SQL.ScalarQuery("Select SMMode from SaleMaster where SMID=" + ID + "");
            if (String.Compare(Type, "CASH") == 0)
            {
                rdo_Cash.Checked = true;
            }
            else rdo_Credit.Checked = true;
        }
        private void Report(int SMID)
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
                string reportPath = (Application.StartupPath + @"\Reports\SaleOrder.rpt");
                var ds = new DataSet();
                String SqlQuery = "select * from TvuSaleOrder where SDSMID=" + SMID + "";
                var adapter = new SqlDataAdapter(SqlQuery, SQL.Con);
                adapter.Fill(ds, "TvuSaleOrder");
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
        private void UpdateInvoice(int row)
        {
            try
            {
                dgv_SaleDetail.Rows[row].Cells["SDID"].Value = "";
                dgv_SaleDetail.Rows[row].Cells["SDSMID"].Value = "";
                dgv_SaleDetail.Rows[row].Cells["SDIMID"].Value = cmb_ItemName.SelectedValue;
                dgv_SaleDetail.Rows[row].Cells["SDIMName"].Value = cmb_ItemName.Text;
                dgv_SaleDetail.Rows[row].Cells["SDICId"].Value = cmb_PIColor.SelectedValue;
                dgv_SaleDetail.Rows[row].Cells["Colour"].Value = cmb_PIColor.Text;
                dgv_SaleDetail.Rows[row].Cells["SDIBID"].Value = cmb_PIBrand.SelectedValue;
                dgv_SaleDetail.Rows[row].Cells["Brand"].Value = cmb_PIBrand.Text;
                dgv_SaleDetail.Rows[row].Cells["SDITID"].Value = cmb_PIType.SelectedValue;
                dgv_SaleDetail.Rows[row].Cells["Type"].Value = cmb_PIType.Text;
                dgv_SaleDetail.Rows[row].Cells["SDQty"].Value = txt_PIQuantity.Text;
                dgv_SaleDetail.Rows[row].Cells["SDUId"].Value = cmb_PIUnit.SelectedValue;
                dgv_SaleDetail.Rows[row].Cells["UnitAbr"].Value = cmb_PIUnit.Text;
                dgv_SaleDetail.Rows[row].Cells["SDRate"].Value = txt_PIUnitPrice.Text;
                dgv_SaleDetail.Rows[row].Cells["SDAmount"].Value = txt_PIAmount.Text;
                dgv_SaleDetail.Rows[row].Cells["rowid"].Value = row;
                SaleInfoClear();
                MessageBox.Show("Record UPDATED successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
            }
        }
        private void enable_disable(bool value)
        {
            txt_CICellNo.Enabled = value;
            txt_CIName.Enabled = value;
            txt_CIRemarks.Enabled = value;
           
            txt_PIQuantity.Enabled = value;
            txt_PIUnitPrice.Enabled = value;
            txt_SaleMasterID.Enabled = value;
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
            cmb_InvoiceType.Enabled = value;
            btn_Print.Enabled = value;
            dgv_SaleDetail.Enabled = value;
        }
        private String GetTotalItem()
        {
            float sum = 0;
            try
            {
                for (int i = 0; i < dgv_SaleDetail.Rows.Count; ++i)
                {
                    sum += float.Parse(dgv_SaleDetail.Rows[i].Cells["SDQty"].Value.ToString());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return sum.ToString();
        }
        private String GetTotalAmount()
        {
            float sum = 0;
            try
            {

                for (int i = 0; i < dgv_SaleDetail.Rows.Count; ++i)
                {
                    sum += float.Parse(dgv_SaleDetail.Rows[i].Cells["SDAmount"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sum.ToString();
        }
        private void GetDetails(int ID)
        {
            try
            {
                var cmd = new SqlCommand("select SDID,SMID,SDUID,SMID,SDIMID,SDICID,ICName,IMName,SDIBID,IBName,SDITID,ITName,SDQty,SDRate,SDAmount,UName from TvuSaleDetail where SMid=" + ID + "", SQL.Con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                for (int s = 0; s <= tbl.Rows.Count - 1; s++)
                {

                    var item = tbl.Rows[s];
                    // dgv_PurchaseDetail.Rows.Add("", "", cmb_ItemName.SelectedValue, cmb_ItemName.Text, cmb_PIColor.SelectedValue, cmb_PIColor.Text, cmb_PIBrand.SelectedValue, cmb_PIBrand.Text, cmb_PIType.SelectedValue, cmb_PIType.Text, txt_PIQuantity.Text, cmb_PIUnit.SelectedValue, cmb_PIUnit.Text, txt_PIUnitPrice.Text, txt_PIAmount.Text);
                    dgv_SaleDetail.Rows.Add(item["SDID"], item["SMID"], item["SDIMID"], item["IMName"], item["SDICID"], item["ICName"], item["SDIBID"], item["IBName"], item["SDITID"], item["ITName"], item["SDQty"], item["SDUID"], item["UName"], item["SDRate"], item["SDAmount"]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GenerateInvoiceNo()
        {
            try
            {
                String DocNo = SQL.ScalarQuery("Select DocNo from DocType where DocType='Sale' and CompanyId=" + Main.CompanyID + "");
                txt_InvoiceNo.Text = DocNo;
                string Compare = "";
                Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM SaleMaster  WHERE SMDocId =" + cmb_InvoiceType.SelectedValue + " ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
                if (string.Compare("True", Compare) == 0)
                {
                    String SMNoo = SQL.ScalarQuery("Select SMNoo from SaleMaster where SMId=(SELECT MAX(SMId) FROM SaleMaster)");
                    if (SMNoo != "")
                    {
                        intSMNoo = int.Parse(SMNoo) + 1;
                        txt_InvoiceNo.Text += intSMNoo.ToString();
                    }
                }
                else
                {
                    String SMNoo = SQL.ScalarQuery("select DocStartFrom from DocType where DocId=" + cmb_InvoiceType.SelectedValue + " ");
                    if (SMNoo != "")
                    {
                        intSMNoo = int.Parse(SMNoo);
                        txt_InvoiceNo.Text += intSMNoo.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("123" + ex.Message);
            }
        }
        //public void GenerateInvoiceNo()
        //{
        //    try
        //    {
        //        String DocNo = SQL.ScalarQuery("Select DocNo from DocType where DocID=" + cmb_InvoiceType.SelectedValue + " and CompanyId=" + Main.CompanyID + "");
        //        String DocNo = SQL.ScalarQuery("IF NOT EXISTS (SELECT DocNo FROM DocType WHERE DocType='Sale' and CompanyID=" + Main.CompanyID + ") begin select 1 end else begin SELECT DocNo FROM DocType WHERE DocType='SA'and companyID=" + Main.CompanyID + " end");
        //        if (String.Compare(DocNo, "-1") == 1)
        //        {
        //            txt_InvoiceNo.Text = DocNo;
        //            string Compare = "";
        //            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM SaleMaster  WHERE SMDocId = " + cmb_InvoiceType.SelectedValue + " ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
        //            if (string.Compare("True", Compare) == 0)
        //            {
        //                String SDNoo = SQL.ScalarQuery("Select SMNoo from SaleMaster where SMId=(SELECT MAX(SMId) FROM SaleMaster)");
        //                if (SDNoo != "")
        //                {
        //                    intSDNoo = int.Parse(SDNoo) + 1;
        //                    txt_InvoiceNo.Text += intSDNoo.ToString();
        //                }
        //            }
        //            else
        //            {
        //                String SDNoo = SQL.ScalarQuery("select DocStartFrom from DocType where DocId=" + cmb_InvoiceType.SelectedValue + " ");
        //                if (SDNoo != "")
        //                {
        //                    intSDNoo = int.Parse(SDNoo);
        //                    txt_InvoiceNo.Text += intSDNoo.ToString();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Unable To Generate Invoice ID");
        //            this.Hide();
        //            var frm = new frm_DocSetup();
        //            frm.ShowDialog();
        //            this.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        public void SaleInfoClear()
        {
            cmb_ItemName.SelectedIndex = 0;
            cmb_PIColor.SelectedIndex = 0;
            cmb_PIBrand.SelectedIndex = 0;
            cmb_PIType.SelectedIndex = 0;
            txt_PIUnitPrice.Text = "";
            txt_PIQuantity.Text = "";
            txt_PIAmount.Text = "";
        }
        private void FormClear()
        {
            SaleInfoClear();
            txt_CIName.Text = string.Empty;
            txt_CICellNo.Text = string.Empty;
            txt_CIRemarks.Text = string.Empty;
            dgv_SaleDetail.Rows.Clear();
            //foreach (DataGridViewRow item in this.dgv_SaleDetail.Rows)
            //{
            //    dgv_SaleDetail.Rows.RemoveAt(item.Index);
            //}
        }
        private void getData()
        {
            try
            {
                txt_PIUnitPrice.Text = "";
                String Result = "0";
                String Val = cmb_ItemName.SelectedValue.ToString();
                int iVal = 0;
                if (!int.TryParse(Val, out iVal))
                {

                }
                else if (int.Parse(cmb_ItemName.SelectedValue.ToString()) != -1)
                {
                    Result = SQL.ScalarQuery("select IMSalesPrice from ItemMaster where IMID=" + int.Parse(cmb_ItemName.SelectedValue.ToString()) + "");

                }
                txt_PIUnitPrice.Text = Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertSaleInvoice()
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
                    SQL.NonScalarQuery(@"Insert into SaleMaster(SMDocID                              ,SMNo                        ,SMNoo            ,SMDate                                                  ,SMCustomerName           ,   SMCustomerCell          ,SMRemarks                    ,SMTQuantity                              ,SMTAmount               ,SMMode      ,SMDueDate                                                   ,CompanyId              )
                                                     values(" + cmb_InvoiceType.SelectedValue + ",'" + txt_InvoiceNo.Text + "', " + intSMNoo + ",'" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "','" + txt_CIName.Text + "','" + txt_CICellNo.Text + "','" + txt_CIRemarks.Text + "' ," + float.Parse(lab_TQuantity.Text) + "," + float.Parse(lab_TAmount.Text) + " ,'" + TMode + "','" + dtp_dueDate.Value.Date.ToString("yyyyMMdd") + "'," + Main.CompanyID + ")  ");
                    txt_SaleMasterID.Text = SQL.ScalarQuery("Select SMID from SaleMaster where SMNoo =" + intSMNoo + "And CompanyId =" + Main.CompanyID + "");
                    int SMID;
                    int.TryParse(txt_SaleMasterID.Text, out SMID);

                    for (int i = 0; i < dgv_SaleDetail.Rows.Count; i++)
                    {
                        //String ItemName = dgv_SaleDetail.Rows[i].Cells["ItemName"].Value.ToString();
                        int ColId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDICId"].Value);
                        int BrandId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDIBId"].Value);
                        int TypeId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDITId"].Value);
                        int UnitId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDUId"].Value);
                        float Quantity = float.Parse(dgv_SaleDetail.Rows[i].Cells["SDQty"].Value.ToString());
                        float Rate = float.Parse(dgv_SaleDetail.Rows[i].Cells["SDRate"].Value.ToString());
                        float Amount = float.Parse(dgv_SaleDetail.Rows[i].Cells["SDAmount"].Value.ToString());
                        SQL.NonScalarQueryTransaction(@"Insert into SaleDetail(      SDSMID                               ,  SDIMID                            ,SDICID        ,SDIBID         ,SDITID          ,SDUID           ,SDQty           ,SDRate      ,SDAmount      ,CompanyID)
                                                                              values (" + int.Parse(txt_SaleMasterID.Text) + " ,'" + cmb_ItemName.SelectedValue + "'," + ColId + " ," + BrandId + ", " + TypeId + " ," + UnitId + "  ," + Quantity + "," + Rate + "," + Amount + "," + Main.CompanyID + ")", trans);
                    }
                    if (rdo_Credit.Checked == true)
                    {
                        SQL.NonScalarQuery(@"Insert Into CashFlow (CFDate                                                  ,CFInvID     ,CFMode,CFAmt)
                                                           Values('" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "' ," + SMID + ",'RECEIVABLE'," + decimal.Parse(lab_TAmount.Text) + ")");
                    }
                    MessageBox.Show("Record Saved Successfully");
                    save = true;
                    //frm_SaleInvoice_Load(sender, e);
                    FormClear();
                    btn_Print.Enabled = true;
                    dgv_SaleDetail.Enabled = true;
                    GetDetails(SMID);
                    // Main.fillDgv(dgv_SaleDetail, "select SDID,SMID,ICName,IMName,IBName,ITName,SDQty,SDRate,SDAmount,UName from TvuSaleDetail where SMid=" + SMID + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    trans.Rollback();
                }
                finally
                {
                    SQL.Con.Close();
                }
            }
        }
        private void UpdateSaleInvoice()
        {
            SQL.Con.Open();
            using (SqlTransaction trans = SQL.Con.BeginTransaction())
            {
                try
                {
                    //  SQL.NonScalarQueryTransaction(@"Insert into SaleMaster(PMDocID                              ,PMNo                        ,PMNoo            ,PMDate                                                  ,PMCustomerName           ,   PMCustomerCell          ,PMRemarks                    ,PMTQuantity                              ,PMTAmount               ,PMMode      ,PMDueDate                                                   ,CompanyId              )
                    //                              values(" + cmb_InvoiceType.SelectedValue + ",'" + txt_InvoiceNo.Text + "', " + intPMNoo + ",'" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "','" + txt_CIName.Text + "','" + txt_CICellNo.Text + "','" + txt_CIRemarks.Text + "' ," + float.Parse(lab_TQuantity.Text) + "," + float.Parse(lab_TAmount.Text) + " ,'" + TMode + "','" + dtp_dueDate.Value.Date.ToString("yyyyMMdd") + "'," + Main.CompanyID + ")  ", trans);
                    int SMID;
                    //float Amount = 0;

                    int.TryParse(txt_SaleMasterID.Text, out SMID);
                    SQL.NonScalarQueryTransaction(@"Update SaleMAster set " +
                                         "SMCustomerNAme='" + txt_CIName.Text + "', " +
                                         "SMCustomerCell='" + txt_CICellNo.Text + "', " +
                                         "SMRemarks = '" + txt_CIRemarks.Text + "', " +
                                         "SMDate =  '" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "', " +
                                         "SMMode = '" + TMode + "', " +
                                         "SMTQuantity=" + float.Parse(lab_TQuantity.Text.ToString()) + ", " +
                                         "SMTAmount = " + float.Parse(lab_TAmount.Text.ToString()) + " where SMID =" + SMID + "", trans);
                    for (int i = 0; i < dgv_SaleDetail.Rows.Count; i++)
                    {
                        //String ItemName = dgv_SaleDetail.Rows[i].Cells["ItemName"].Value.ToString();
                        int ItemID = int.Parse(dgv_SaleDetail.Rows[i].Cells["SDIMID"].Value.ToString());
                        int ColId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDICId"].Value);
                        int BrandId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDIBId"].Value);
                        int TypeId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDITId"].Value);
                        int UnitId = Convert.ToInt32(dgv_SaleDetail.Rows[i].Cells["SDUId"].Value);
                        float Quantity = float.Parse(dgv_SaleDetail.Rows[i].Cells["SDQty"].Value.ToString());
                        float Rate = float.Parse(dgv_SaleDetail.Rows[i].Cells["SDRate"].Value.ToString());
                        float Amount = float.Parse(dgv_SaleDetail.Rows[i].Cells["SDAmount"].Value.ToString());
                        //SQL.NonScalarQueryTransaction(@"Insert into SaleDetail(      PDPMID         ,  PDIMID        ,PDICID          ,PDIBID        ,PDITID          ,PDUID           ,PDQty          ,PDRate       ,PDAmount,CompanyID)
                        //     values (" + int.Parse(txt_PuchaseMasterID.Text) + " ,'" + cmb_ItemName.SelectedValue + "'," + ColId + " ," + BrandId + ", " + TypeId + " ," + UnitId + "  ," + Quantity + "," + Rate + "," + Amount + "                  ," + Main.CompanyID + ")", trans);
                        SQL.NonScalarQueryTransaction("UPdate SaleDetail set  " +
                            "SDIMID = " + ItemID + ", " +
                            "SDICID = " + ColId + ", " +
                            "SDIBID = " + BrandId + " , " +
                            "SDITID = " + TypeId + " , " +
                            "SDQty  = " + Quantity + ", " +
                          "SDAmount = " + Amount + " , " +
                            "SDRate = " + Rate + "", trans);
                    }
                    save = true;
                    if (rdo_Credit.Checked == true)
                    {
                        SQL.NonScalarQueryTransaction(@"Update CashFlow set " +
                                                        "CFDate = '" + datetimePicker.Value.Date.ToString("yyyyMMdd") + "', " +
                                                        "CFAmount=" + decimal.Parse(lab_TAmount.Text) + "", trans);
                    }
                    MessageBox.Show("Record Saved Successfully");
                    FormClear();
                    dgv_SaleDetail.Enabled = true;
                    GetDetails(SMID);
                    ///Main.fillDgv(dgv_SaleDetail, "select SDID,SMID,ICName,IMName,IBName,ITName,SDQty,SDRate,SDAmount,UName from TvuSaleDetail where SMid=" + SMID + "");
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
        //Function End
        public frm_SaleInvoice()
        {
            InitializeComponent();
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
            else if (dgv_SaleDetail.RowCount < 1)
            {
                MessageBox.Show("No Item Avaiable In Cart", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Insert The Current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    InsertSaleInvoice();
                    btn_Save.Enabled = false;

                }
            }

            else if (mode == 2)
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Update The Current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    UpdateSaleInvoice();
                    btn_Save.Enabled = false;

                }
            }
        }

        private void txt_PIQuantity_TextChanged(object sender, EventArgs e)
        {
            txt_PIUnitPrice_TextChanged(sender, e);
        }
        private void txt_PIUnitPrice_TextChanged(object sender, EventArgs e)
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
                try
                {
                    int row = dgv_SaleDetail.RowCount;
                    //////-------------------------SDID,SDNO itemID     ItemName
                    dgv_SaleDetail.Rows.Add("", "", cmb_ItemName.SelectedValue, cmb_ItemName.Text, cmb_PIColor.SelectedValue, cmb_PIColor.Text, cmb_PIBrand.SelectedValue, cmb_PIBrand.Text, cmb_PIType.SelectedValue, cmb_PIType.Text, txt_PIQuantity.Text, cmb_PIUnit.SelectedValue, cmb_PIUnit.Text, txt_PIUnitPrice.Text, txt_PIAmount.Text);
                    lab_TQuantity.Text = GetTotalItem();
                    lab_TAmount.Text = GetTotalAmount();
                    SaleInfoClear();
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
                int index = int.Parse(txt_rowid.Text);
                foreach (DataGridViewRow item in this.dgv_SaleDetail.SelectedRows)
                {
                    dgv_SaleDetail.Rows.RemoveAt(item.Index);
                }
                lab_TAmount.Text = GetTotalAmount();
                lab_TQuantity.Text = GetTotalItem();

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

        private void frm_SaleInvoice_Load(object sender, EventArgs e)
        {
            String ItemMaster = SQL.ScalarQuery("SELECT COUNT(IMName) FROM ItemMaster WHERE CompanyID=" + Main.CompanyID + "");
            String ItemBrand = SQL.ScalarQuery("SELECT COUNT(IBName) FROM ItemBrand WHERE CompanyID=" + Main.CompanyID + "");
            String ItemColor = SQL.ScalarQuery("SELECT COUNT(ICName) FROM ItemColor WHERE CompanyID=" + Main.CompanyID + "");
            String ItemType = SQL.ScalarQuery("SELECT COUNT(ITName) FROM ItemType WHERE CompanyID=" + Main.CompanyID + "");
            String DocType = SQL.ScalarQuery("SELECT COUNT(DOCid) FROM DocType where  CompanyID=" + Main.CompanyID + " and DocType='Sale'");
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
                Main.fillCombo(cmb_InvoiceType, "DocType", "DocType", "DocID", "DocType='Sale'");
                //Unit Setup
                Main.fillCombo(cmb_PIUnit, "UnitSetup", "UName", "UID", "UActive=1");
                GenerateInvoiceNo();
                ////setup 
                lab_TAmount.Text = "0";
                lab_TQuantity.Text = "0";
                txt_PIUnitPrice.Text = "";
                enable_disable(false);
                btn_New.Enabled = true;
            }
        }
        private void dgv_SaleDetail_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dgv_SaleDetail.Rows[index];
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (save == false)
                {
                    MessageBox.Show("Record Not Save Yet, Please Save The Record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int IMEI_SDID = int.Parse(selectedrow.Cells["SDID"].Value.ToString());
                    int IMEI_SMID = int.Parse(selectedrow.Cells["SDSMID"].Value.ToString()); ;
                    string IMEI_ItemNAme = selectedrow.Cells["SDIMName"].Value.ToString();
                    float IMEI_Quantity = float.Parse(selectedrow.Cells["SDQty"].Value.ToString());
                    var frm = new frm_IMEI(IMEI_SMID, IMEI_SDID, IMEI_Quantity, IMEI_ItemNAme, 2);
                    frm.ShowDialog();
                }
            }
            if (save == false)
            {
                try
                {
                    SaleInfoClear();
                    if (index > -1)
                    {
                        txt_rowid.Text = index.ToString();
                        cmb_ItemName.SelectedIndex = int.Parse(selectedrow.Cells["SDIMID"].Value.ToString()) - 1;
                        txt_PIQuantity.Text = selectedrow.Cells["SDQty"].Value.ToString();
                        txt_PIUnitPrice.Text = selectedrow.Cells["SDRate"].Value.ToString();
                        txt_PIAmount.Text = selectedrow.Cells["SDAmount"].Value.ToString();
                        cmb_PIColor.SelectedIndex = int.Parse(selectedrow.Cells["SDICId"].Value.ToString()) - 1;
                        cmb_PIBrand.SelectedIndex = int.Parse(selectedrow.Cells["SDIBId"].Value.ToString()) - 1;
                        cmb_PIType.SelectedIndex = int.Parse(selectedrow.Cells["SDITId"].Value.ToString()) - 1;
                        btn_Remove.Enabled = true;
                    }
                    index = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            int SMID;
            if (save == false)
            {
                MessageBox.Show("Please Save Order First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txt_SaleMasterID.Text, out SMID))
            {
                MessageBox.Show("An unkown error occour during excecution1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_SaleMasterID.Text == "")
            {
                MessageBox.Show("An unkown error occour during excecution2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Report(SMID);
            }
        }
        private void txt_PIQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_PIUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnfnd_Click(object sender, EventArgs e)
        {
            pnl_find.Visible = true;
            Main.fillDgv(dgv_find, "select SMID,SMNo,SMDAte,SMCustomerName,SMCustomerCell,SMRemarks,SMTQuantity,SMTAmount,SMMode from SaleMaster ");
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
                SaleInfoClear();
                string Date = "";
                DataGridViewRow selectedrow = dgv_find.Rows[index];
                if (index > -1)
                {
                    //Sale Detaild
                    txt_rowid.Text = index.ToString();
                    txt_SaleMasterID.Text = selectedrow.Cells["SMID1"].Value.ToString();
                    //purcahse Detail
                    txt_CIName.Text = selectedrow.Cells["Name"].Value.ToString();
                    txt_CICellNo.Text = selectedrow.Cells["CellNo"].Value.ToString();
                    Date = selectedrow.Cells["Date"].Value.ToString();
                    // txt_CIRemarks.Text = selectedrow.Cells["Remarks"].Value.ToString();
                    dgv_SaleDetail.Enabled = true;
                    btn_Remove.Enabled = true;
                }
                index = 0;

                int ID = 0;
                if (int.TryParse(txt_SaleMasterID.Text, out ID))
                {
                    GetDetails(ID);
                    //Main.fillDgv(dgv_SaleDetail, "select SDID,SMID,SDIMID,SDICID,ICName,IMName,SDIBID,IBName,SDITID,ITName,SDQty,SDRate,SDAmount,UName from TvuSaleDetail where SMid=" + ID + "");
                }
                txt_InvoiceNo.Text = SQL.ScalarQuery("Select SMNo from SaleMaster where SMID=" + ID + " ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_find, "  select SMID,SMNo,SMDAte,SMCustomerName,SMCustomerCell,SMRemarks,SMTQuantity,SMTAmount,SMMode from SaleMaster where  CAST(SMNo  as varchar)+ CAST (SMCustomerName as varchar) like '%" + txt_Find.Text + "%'");
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
    }
}
