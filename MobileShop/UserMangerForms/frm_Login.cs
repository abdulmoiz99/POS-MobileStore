using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShop.UserMangerForms;
using System.Data.SqlClient;
using MobileShop.SetupForms;

namespace MobileShop
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SQL.DataSource))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connrction to the Sql Server Failed Application is Exiting", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                Application.Exit();
            }
            else
            {
                String Company = SQL.ScalarQuery("SELECT COUNT(CompanyID) FROM CompanySetup where CompanyActive=1");
                if (Company == "0")
                {
                    MessageBox.Show("No Company Is Created " + System.Environment.NewLine + "Please Create A company First ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                else
                {
                    Main.getCompany(cmb_CompanyName, "CompanySetup", "CompanyName", "CompanyId", "CompanyActive=1");
                    txt_Username.Focus();
                }
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (Rights.CheckSuper(txt_Password.Text) == true)
            {
                this.Hide();
                var NEW = new frm_Main();
                NEW.ShowDialog();
            }
            else
            {
                if (cmb_CompanyName.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Company", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Main.CompanyID = int.Parse(cmb_CompanyName.SelectedValue.ToString());
                    if (txt_Username.Text != "")
                    {

                        if (txt_Password.Text != "")
                        {
                            if (Main.CheckUserName(txt_Username.Text) == true)
                            {
                                if (Main.checkPassword(txt_Username.Text, txt_Password.Text) == true)
                                {
                                    Main.UserName = txt_Username.Text;
                                    String RDRmid= SQL.ScalarQuery("select isnull(RoleID,0) from Login where UserName='" + txt_Username.Text + "'and password = '" + txt_Password.Text + "'and CompanyID =" + Main.CompanyID + "	");
                                    if (!int.TryParse(RDRmid, out Main.RDRMID))
                                    {
                                        MessageBox.Show("Unable To Get Role ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    this.Hide();
                                    var NEW = new frm_Main();
                                    NEW.ShowDialog();

                                }
                                else MessageBox.Show("Invalid Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            }
                            else MessageBox.Show("Invalid Username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else MessageBox.Show("Please Enter Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else MessageBox.Show("Please Enter UserName", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lab_CreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_CreateUsere();
            frm.ShowDialog();
            this.Close();
        }
        private void lab_CreateAccount_MouseHover(object sender, EventArgs e)
        {
            lab_CreateAccount.Font = new Font(lab_CreateAccount.Font.Name, lab_CreateAccount.Font.SizeInPoints, FontStyle.Underline);
        }
        private void lab_CreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lab_CreateAccount.Font = new Font(lab_CreateAccount.Font.Name, lab_CreateAccount.Font.SizeInPoints, FontStyle.Regular);
        }
        private void txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '●';
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
