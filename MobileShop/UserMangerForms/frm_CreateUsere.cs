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

namespace MobileShop.UserMangerForms
{
    public partial class frm_CreateUsere : Form
    {
        public frm_CreateUsere()
        {
            InitializeComponent();
        }

        private void frm_CreateUsere_Load(object sender, EventArgs e)
        {
            String Company = SQL.ScalarQuery("SELECT COUNT(CompanyID) FROM CompanySetup where CompanyActive=1");
            String Role = SQL.ScalarQuery(" SELECT COUNT(RoleID) FROM RoleMaster");
            if (Company == "0")
            {
                MessageBox.Show("No Company Is Created" + System.Environment.NewLine + "Please Create A company First ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try
                {
                    this.Hide();
                    var frm = new frm_AddRole();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                }
            }
            else if(Role == "0")
            {
                MessageBox.Show("No Role Type Is Created" + System.Environment.NewLine + "Please Create A Role First ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try
                {
                    this.Hide();
                    var frm = new Frm_AddRole();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                Main.fillComboWithoutCondition(cmb_CompanyName, "CompanySetup", "CompanyName", "CompanyID");
                Main.fillComboWithoutCondition(cmb_UserType, "RoleMaster", "RoleName", "RoleID");
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_Login();
            frm.ShowDialog();
            this.Close();
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Main.CheckUserName(txt_UserName.Text) == true)
            {
                MessageBox.Show("Username Already Taken", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmb_CompanyName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select A Company", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (cmb_UserType.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select User Role", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Create A New User", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (YorN == DialogResult.Yes)
                {
                    SQL.NonScalarQuery(@"Insert into login (Username,Password,RoleID,companyid) 
                                                     values('" + txt_UserName.Text + "','" + txt_Password.Text + "'," + cmb_UserType.SelectedValue + "," + cmb_CompanyName.SelectedValue + ")");
                    MessageBox.Show("NEW ACCOUNT CREATED SUCCESSFULLY", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var frm = new frm_Login();
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }
        private void txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '●';
        }
    }
}
