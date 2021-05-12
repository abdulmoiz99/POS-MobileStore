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
using MobileShop.TransictionsForms;
using DevExpress.XtraNavBar;
namespace MobileShop
{
    public partial class frm_Main : Form
    {

        public frm_Main()
        {
            InitializeComponent();
        }
        private void btn_Purchasereturn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }
        private void btn_PurchaseOrder_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {

                var frm = new frm_PurchaseInvoices();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }
        private void btn_CompanySetup_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {

                var frm = new frm_AddRole();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }
        private void btn_UnitSetup_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {

                var frm = new frm_UnitSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }

        }
        private void btn_VoucherSetup_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_DocSetup(true);
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }
        private void btn_IMType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {

                var frm = new frm_TypeSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }
        private void btn_IMBrand_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_BrandSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }

        }
        private void btn_IMColor_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_ColorSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }
        private void btn_main_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_Dashboard();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                var frm = new frm_Dashboard();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }
        private void AddNewItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_AddItem();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }
        private void btn_SaleOrder_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_SaleInvoice();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            catch (Exception)
            {
            }
        }
        private void btn_NewCompany_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_AddRole(true);
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {

            }
        }
        private void btn_ExpenseSetup_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {

                var frm = new frm_ExpenseSetup();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }

        private void btn_FormAndReportsRights_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            try
            {
                var frm = new frm_FormAndReportsRights();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }

        }
        private void btn_AddForm_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_AddFrom();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }

        private void btn_AddReport_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_AddReport();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }

        private void btn_AddExpense_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new frm_AddExpense();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }

        }

        private void btn_CashFlow_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                var frm = new Frm_CashFlow();
                frm.MdiParent = this; // assign MdiParent of FormB to FormC
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception)
            {
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult YorN = MessageBox.Show("Are you sure to exit application", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YorN == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Exit_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Application.Exit();
        }
    }
}
