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
    public partial class frm_FormAndReportsRights : Form
    {
        public frm_FormAndReportsRights()
        {
            InitializeComponent();
        }

        private void frm_FormAndReportsRights_Load(object sender, EventArgs e)
        {
            Main.fillComboWithoutCondition(cmb_UserType, "RoleMaster", "RoleName", "RoleID");
            // Main.fillDgv(dgv_FormRights, "Select * from FormSetup");
            // MessageBox.Show(dgv_FormRights.Rows[1].Cells["FormID"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void cmb_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_FormList, "select * from formSetup");

            dgv_FormRights.Rows.Clear();
            dgv_FormRights.Refresh();
            String Count = SQL.ScalarQuery("select COUNT(FORmID) from formSetup");
            int iCount;
            if (!int.TryParse(Count, out iCount))
            {
                MessageBox.Show("ERROR COUNT");
            }
            else
            {
                for (int i = 0; i < dgv_FormList.RowCount; i++)
                {

                    int formId = int.Parse(dgv_FormList.Rows[i].Cells["FId"].Value.ToString());
                    string formName = dgv_FormList.Rows[i].Cells["FName"].Value.ToString();
                    int RDRMID = int.Parse(cmb_UserType.SelectedValue.ToString());

                    bool Acceess = Rights.getAccess(RDRMID, formId);
                    bool Add = Rights.getAdd(RDRMID, formId);
                    bool Edit = Rights.getEdit(RDRMID, formId);
                    bool Delete = Rights.getDelete(RDRMID, formId);
                    //++    formid   formName  access add1 edit1  delete1  print1   
                    dgv_FormRights.Rows.Add(RDRMID, formId, formName, Acceess, Add, Edit, Delete);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_FormRights.RowCount; i++)
            {
                int Access = Convert.ToInt32(dgv_FormRights.Rows[i].Cells["Access"].Value);
                int Add = Convert.ToInt32(dgv_FormRights.Rows[i].Cells["Add1"].Value);
                int Edit = Convert.ToInt32(dgv_FormRights.Rows[i].Cells["Edit1"].Value);
                int Delete = Convert.ToInt32(dgv_FormRights.Rows[i].Cells["Delete1"].Value);
                int RDRMID = Convert.ToInt32(dgv_FormRights.Rows[i].Cells["RDRMID"].Value);
                int FormID = Convert.ToInt32(dgv_FormRights.Rows[i].Cells["FormID"].Value);
                if (Rights.CheckForm(RDRMID, FormID) == true)
                {
                    SQL.NonScalarQuery("update Roledetail set access=" + Access + ", add1=" + Add + ",edit1=" + Edit + ",delete1=" + Delete + " where formId=" + FormID + " And RDRMID=" + RDRMID + "");
                }
                else if (Rights.CheckForm(FormID, RDRMID) == false)
                {
                    SQL.NonScalarQuery(@"Insert into Roledetail (RDRMID    ,FormID    ,Access    ,Add1   ,edit1     ,delete1)
                                                          values(" + RDRMID + "," + FormID + "," + Access + "," + Add + "," + Edit + " ," + Delete + ")");
                }
            }
            MessageBox.Show("Rights Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btn_exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
