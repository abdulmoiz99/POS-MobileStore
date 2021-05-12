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
using MobileShop.UserMangerForms;

namespace MobileShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            var NEW = new frm_SaleInvoice();
            //var NEW = new  Frm_CashFlow();
            NEW.ShowDialog();
            this.Close();
        }
    }
}
