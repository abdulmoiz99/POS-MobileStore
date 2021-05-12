using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.TransictionsForms
{
    public partial class Frm_CashFlow : Form
    {
        string mode = "";
        string FName = "CashFlow";
        float TAmount;
        float TBalance;
        bool AllowTrans = false;
        public Frm_CashFlow()
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
        private void Check_Amount()
        {

            double totAmt = double.Parse(txt_CAmount.Text);
            try
            {
                foreach (DataGridViewRow r in this.dgv_CashFlow.Rows)
                {
                    if (r.Visible == true && bool.Parse(r.Cells["Select"].Value.ToString()) == true)
                    {
                        if (totAmt <= 0)
                        {
                            break;
                        }
                        if (totAmt >= double.Parse(r.Cells["Balance"].Value.ToString()))
                        {
                            r.Cells["PayAmt"].Value = r.Cells["Balance"].Value;
                            totAmt = totAmt - double.Parse(r.Cells["PayAmt"].Value.ToString());
                        }
                        else
                        {
                            r.Cells["PayAmt"].Value = totAmt;
                            totAmt = totAmt - double.Parse(r.Cells["PayAmt"].Value.ToString());
                        }
                    }
                    if (totAmt > 0)
                    {
                        MessageBox.Show("You Have Enter More Amount Than The Balance Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else AllowTrans = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetTotalAmount()
        {
            //float TAmt = 0;
            //foreach (DataGridViewRow r in dgv_CashFlow.Rows)
            //{
            //    bool check = false;
            //    MessageBox.Show(r.Cells["C"].Value.ToString());
            //    //if (r.Visible == true && bool.Parse(r.Cells["Select"].Value.ToString()) == true)

            //    //// MessageBox.Show(r.Cells["Select"].Value.ToString());
            //    ////if (bool.TryParse(r.Cells["Select"].Value.ToString(), out check))
            //    ////{
            //    //{
            //    //    //    TAmt += Convert.ToInt32(r.Cells["Amount"].Value);
            //    //}
            //    //}
            //}
            //return TAmt;
        }
        private float GetTotalBalance()
        {
            float TBal = 0;
            //foreach (DataGridViewRow r in this.dgv_CashFlow.Rows)
            //{
            //    try
            //    {
            //        if (r.Visible == true && bool.Parse(r.Cells["Select"].Value.ToString()) == true)
            //        {
            //            TBal += float.Parse(r.Cells["Balance"].Value.ToString());
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            return TBalance;
        }
        private void LabelEmpty()
        {
            lab_Amt.Text = "------";
            lab_Balance.Text = "------";
            //lab_InvNo.Text = "------";
            lab_Mode.Text = "------";
            lab_PartyName.Text = "------";
        }
        private void enable_disable(bool torf)
        {
            rdo_Payable.Enabled = torf;
            rdo_receviable.Enabled = torf;
            cmb_PartyName.Enabled = torf;
            btn_Find.Enabled = torf;
            dgv_CashFlow.Enabled = torf;
            txt_CAmount.Enabled = torf;
            button1.Enabled = torf;
        }
        private void AllClear()
        {
            
            txt_CAmount.Text = string.Empty;
            cmb_PartyName.SelectedIndex = 0;
        }
        private void Frm_CashFlow_Load(object sender, EventArgs e)
        {

            LabelEmpty();
            enable_disable(false);
            Main.fillComboWithQuery(cmb_PartyName, "PartyName", "select distinct partyname from TvuFrmPartyName");
        }
        private void dgv_CashFlow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  try
            // {
            GetTotalAmount();
            int index = e.RowIndex;
            if (index > -1)
            {
                DataGridViewRow selectedrow = dgv_CashFlow.Rows[index];
                lab_PartyName.Text = selectedrow.Cells["PartyName"].Value.ToString();
                lab_PMID.Text = selectedrow.Cells["PMID"].Value.ToString();
                //   lab_InvNo.Text = selectedrow.Cells["RecNo"].Value.ToString();
                lab_Mode.Text = selectedrow.Cells["Mode1"].Value.ToString();
                //lab_Amt.Text = GetTotalAmount().ToString();// selectedrow.Cells["Amount"].Value.ToString();
                //lab_Balance.Text = GetTotalBalance().ToString();//selectedrow.Cells["Balance"].Value.ToString();
            }
            index = 0;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int PMID;
            if (Rights.Add(Main.RDRMID, FName) == false)
            {
                MessageBox.Show("You donot have permision to add new item", "Permision Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_CAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(lab_PMID.Text, out PMID))
            {
                MessageBox.Show("Invalid Invoice no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Check_Amount();
                if (AllowTrans == true)
                {
                    DialogResult YorN = MessageBox.Show("Are You Sure To Perform The Tranaction ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YorN == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in this.dgv_CashFlow.Rows)
                        {
                            if (r.Visible == true && bool.Parse(r.Cells["Select"].Value.ToString()) == true)
                            {
                                float CFAmt = float.Parse(r.Cells["Balance"].Value.ToString()) - float.Parse(r.Cells["PayAmt"].Value.ToString());
                                SQL.NonScalarQuery("update CashFlow set CFAmt=" + CFAmt + " where CFMode='" + mode + "' AND CFinvID=" + PMID + "");
                            }
                        }

                        LabelEmpty();
                        txt_CAmount.Text = "";
                        btn_cancel_Click(sender, e);
                    }
                }
            }
        }
        private void txt_CAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }
        private void btn_New_Click_1(object sender, EventArgs e)
        {
            String CashFlow = SQL.ScalarQuery("SELECT COUNT(PartyName) FROM TvuFrmPartyName");
            if (CashFlow == "0")
            {
                MessageBox.Show("No Invoice Related To Credit Is Issued ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DataGridViewRow item in this.dgv_CashFlow.Rows)
                {
                    dgv_CashFlow.Rows.RemoveAt(item.Index);
                }
                enable_disable(true);
                btn_New.Enabled = false;
                btn_cancel.Enabled = true;
                LabelEmpty();
                AllClear();
            }
        }
        private void btn_Find_Click_1(object sender, EventArgs e)
        {
            if (rdo_Payable.Checked == true)
            {
                mode = "PAYABLE";
            }
            else mode = "RECEIVABLE";
            Main.fillDgv(dgv_CashFlow, "select Mode , RecID , RECno ,partyname ,amount ,CFAmt from TvuFrmCashFlow where partyname ='" + cmb_PartyName.Text + "' and mode ='" + mode + "'");
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            enable_disable(false);
            AllClear();
            LabelEmpty();
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
        }
        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            // Check_Amount();
            //MessageBox.Show(dgv_CashFlow.Rows[1].Cells["Select"].Value.ToString());
            //lab_Amt.Text = GetTotalAmount().ToString();
        }
        private void btn_exitForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {

        }
    }
}

