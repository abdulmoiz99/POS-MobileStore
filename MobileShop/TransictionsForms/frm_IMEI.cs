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
    public partial class frm_IMEI : Form
    {
        int PMID;
        int PDID;
        float Quantity;
        string ItemName;
        int mode; //1 for PD,2 For SD
        public frm_IMEI()
        {
            InitializeComponent();
        }
        public frm_IMEI(int PMID, int PDID, float Quantity, string ItemName,int mode)
        {
            InitializeComponent();
            this.PMID = PMID;
            this.PDID = PDID; ;
            this.Quantity = Quantity;
            this.ItemName = ItemName;
            this.mode = mode;
            Lab_Quantity.Text = Quantity.ToString();
            lab_ItemName.Text = ItemName; 

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            btn_Save.Focus();
            for (int i = dgv_IMEI.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = dgv_IMEI.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    dgv_IMEI.Rows.RemoveAt(i);
                }
            }
            if (dgv_IMEI.RowCount - 1 < Quantity)
            {
                MessageBox.Show("IMEI Numebers Are Less than Quantity", "WArning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgv_IMEI.RowCount - 1 > Quantity)
            {
                MessageBox.Show("IMEI Numebers Are greater than Quantity", "WArning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < dgv_IMEI.RowCount - 1; i++)
                {
                    String IMEINo = "";
                    String BarCode = "";
                    try
                    {
                        IMEINo = dgv_IMEI.Rows[i].Cells["IMEI"].Value.ToString();
                        BarCode = dgv_IMEI.Rows[i].Cells["BarCode"].Value.ToString();
                    }
                    catch (Exception) { }
                    int iIMEI = 0;
                    int iBarCode = 0;
                    if (IMEINo == "" && BarCode == "")
                    {
                        MessageBox.Show("Please Enter IMEI No Or Barcode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }



                    else if (!int.TryParse(IMEINo, out iIMEI))
                    {
                        MessageBox.Show("Invalid IMEI No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!int.TryParse(BarCode, out iBarCode))
                    {
                        MessageBox.Show("Invalid Barcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (mode ==1)
                        {
                            SQL.NonScalarQuery(@"Insert into PurchaseDetail2 (PDID,PMID,IMEINo,BarCode) 
                                                                   values(" + PDID + "," + PMID + "," + iIMEI + "," + iBarCode + ")");
                            MessageBox.Show("Record Added Successfully", "Sccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if(mode == 2)
                        {
                            SQL.NonScalarQuery(@"Insert into SaleDetail2 (SDID,SMID,IMEINo,BarCode) 
                                                                   values(" + PDID + "," + PMID + "," + iIMEI + "," + iBarCode + ")");
                            MessageBox.Show("Record Added Successfully", "Sccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }

        }

        private void dgv_IMEI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
