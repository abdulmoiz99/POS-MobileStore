using DevExpress.XtraCharts;
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
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }
        private void TodayDetails()
        {
            Lab_TodayPurchase.Text = SQL.ScalarQuery("SELECT isnull(Sum(PMTAmount),0) FROM PurchaseMASTER where PMMode='Cash' And PMDate=(select convert(date, GETDATE()))");
            Lab_TodaySale.Text = SQL.ScalarQuery("SELECT isnull(Sum(SMTAmount),0) FROM SaleMASTER where SMMode='Cash' And SMDate=(select convert(date, GETDATE()))");
            String CashPaid = SQL.ScalarQuery("SELECT COUNT(Paid) FROM TvuFrmDailyCounter  where  RecDate=(select convert(date, GETDATE()))");
            if (CashPaid != "0")
            {
                Lab_TodayPaid.Text = SQL.ScalarQuery("SELECT Sum(Paid) FROM TvuFrmDailyCounter where  RecDate=(select convert(date, GETDATE()))");
            }
            else Lab_TodayPaid.Text = "0";
            String CashRec = SQL.ScalarQuery("SELECT COUNT(receive) FROM TvuFrmDailyCounter where  RecDate=(select convert(date, GETDATE()))");
            if (CashRec != "0")
            {
                Lab_TodayReceive.Text = SQL.ScalarQuery("SELECT Sum(receive) FROM TvuFrmDailyCounter where  RecDate=(select convert(date, GETDATE()))");
            }
            else Lab_TodayReceive.Text = "0";
        }
        public bool CheckTodayOpening()
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS(SELECT TOP 1 * FROM DailyCounter  WHERE DCDate= (select convert(date, GETDATE()))) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        private void TodayProfit()
        {
            lab_TodayProfit.Text = SQL.ScalarQuery("select isnull(sum((Opening-(Payamt+Paid))+(recamt+receive)),0) from TvuFrmDailyCounter where RecDate=(select convert(date,GETDATE()))");
            float Profit;
            if (float.TryParse(lab_TodayProfit.Text, out Profit))
            {
                if (Profit <= 0)
                {
                    pnl_Profit.BackColor = Color.FromArgb(243, 92, 86);
                }
                else pnl_Profit.BackColor = Color.FromArgb(26, 161, 95);
            }
            lab_TodayProfit.Text = Profit.ToString();
        }
        private void PurchaseOrderChart()
        {
            string TodayPM = SQL.ScalarQuery("SELECT COUNT(PMID) FROM PurchaseMaster WHERE PMdate = (select convert(date, GETDATE()))");
            int iTodayPM;
            if (int.TryParse(TodayPM, out iTodayPM))
            {
                iTodayPM = int.Parse(TodayPM);
            }
            else iTodayPM = 1;
            string YesterdayPM = SQL.ScalarQuery("SELECT COUNT(PMID) FROM PurchaseMaster WHERE PMdate=(select convert (date,DATEADD(D,-1,GETDATE())))");
            int iYesterdayPM;
            if (int.TryParse(YesterdayPM, out iYesterdayPM))
            {
                iYesterdayPM = int.Parse(YesterdayPM);
            }
            else iYesterdayPM = 1;
            string TwoDayAgoPM = SQL.ScalarQuery("SELECT COUNT(PMID) FROM PurchaseMaster WHERE PMdate=(select convert (date,DATEADD(D,-2,GETDATE())))");
            int iTwoDayAgoPM;
            if (int.TryParse(TwoDayAgoPM, out iTwoDayAgoPM))
            {
                iTwoDayAgoPM = int.Parse(TwoDayAgoPM);
            }
            else iTwoDayAgoPM = 1;
            Series PurchaseOrder = new Series("LastDay", ViewType.Doughnut);
            PurchaseOrder.Points.Add(new SeriesPoint("Today", iTodayPM));
            PurchaseOrder.Points.Add(new SeriesPoint("Yesterday", iYesterdayPM));
            PurchaseOrder.Points.Add(new SeriesPoint("Two Days Ago", iTwoDayAgoPM));
            //PurchaseOrder.Label.TextPattern = "{A}: {VP:P0}";
            PurchaseOrder.Label.TextPattern = "{A}:{V}";
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "PURCHASE ORDER";
            //chartTitle1.Font = new Font("BigNoodleTitling", chartTitle1.Font.Size);
            Chart_PurchaseOrder.Titles.Add(chartTitle1);
            Chart_PurchaseOrder.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            PieSeriesView view = (PieSeriesView)PurchaseOrder.View;
            view.FillStyle.FillMode = FillMode.Solid;
            Chart_PurchaseOrder.Series.Add(PurchaseOrder);
            // Adjust the view-type-specific options of the series. 
            ((DoughnutSeriesView)PurchaseOrder.View).ExplodedPoints.Add(PurchaseOrder.Points[0]);
            ((DoughnutSeriesView)PurchaseOrder.View).ExplodedDistancePercentage = 25;
        }
        private void SaleOrderChart()
        {
            string TodaySM = SQL.ScalarQuery("SELECT COUNT(SMID) FROM SaleMaster WHERE SMdate = (select convert(date, GETDATE()))");
            int iTodaySM;
            if (int.TryParse(TodaySM, out iTodaySM))
            {
                iTodaySM = int.Parse(TodaySM);
            }
            else iTodaySM = 1;
            string YesterdaySM = SQL.ScalarQuery("SELECT COUNT(SMID) FROM SaleMaster WHERE SMdate=(select convert (date,DATEADD(D,-1,GETDATE())))");
            int iYesterdaySM;
            if (int.TryParse(YesterdaySM, out iYesterdaySM))
            {
                iYesterdaySM = int.Parse(YesterdaySM);
            }
            else iYesterdaySM = 1;
            string TwoDayAgoSM = SQL.ScalarQuery("SELECT COUNT(SMID) FROM SaleMaster WHERE SMdate=(select convert (date,DATEADD(D,-2,GETDATE())))");
            int iTwoDayAgoSM;
            if (int.TryParse(TwoDayAgoSM, out iTwoDayAgoSM))
            {
                iTwoDayAgoSM = int.Parse(TwoDayAgoSM);
            }
            else iTwoDayAgoSM = 1;
            Series SaleOrder = new Series("LastDay", ViewType.Doughnut);
            SaleOrder.Points.Add(new SeriesPoint("Today", iTodaySM));
            SaleOrder.Points.Add(new SeriesPoint("Yesterday", iYesterdaySM));
            SaleOrder.Points.Add(new SeriesPoint("Two Days Ago", iTwoDayAgoSM));
            SaleOrder.Label.TextPattern = "{A}:{V}";
            ChartTitle chartTitle2 = new ChartTitle();
            chartTitle2.Text = "SALE ORDER";
            Chart_SaleOrder.Titles.Add(chartTitle2);
            Chart_SaleOrder.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            Chart_SaleOrder.Series.Add(SaleOrder);
            ((DoughnutSeriesView)SaleOrder.View).ExplodedPoints.Add(SaleOrder.Points[0]);
            ((DoughnutSeriesView)SaleOrder.View).ExplodedDistancePercentage = 25;
        }
        private void CashFlowAmount()
        {
            string PAmt = SQL.ScalarQuery("SELECT isnull(SUM(CFAmt),0) FROM CashFlow WHERE CFMode = 'PAYABLE'");
            String RAmt = SQL.ScalarQuery("SELECT isnull(SUM(CFAmt),0) FROM CashFlow WHERE CFMode = 'RECEIVABLE'");
            lab_PayAmt.Text = PAmt + "/-";
            lab_RecAmt.Text = RAmt + "/-";
        }
        private void TodayExpense()
        {
            Main.fillDgv(dgv_Expense, "select ESName ,EAmount from TvuExpenses  where EDate=(select convert(date,GETDATE()))");
            String TAmt = SQL.ScalarQuery("SELECT isnull(SUM(EAmount),0) FROM TvuExpenses WHERE EDate=(select convert(date,GETDATE()));");
            if (TAmt == "0")
            {
                lab_ExpenseTotal.Text = "0/-";
            }
            else lab_ExpenseTotal.Text = TAmt + "/-";
            if (dgv_Expense.RowCount <= 0)
            {
                pnl_Expense.Visible = true;
            }
        }
        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                TodayDetails();
                TodayExpense();
                CashFlowAmount();
                TodayProfit();
                PurchaseOrderChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                SaleOrderChart();
                // Company Name 
                lab_CompanyName.Text = "TECH WORK";// SQL.ScalarQuery("Select CompanyName From CompanySetup where CompanyID=" + Main.CompanyID + "");
                lab_Username.Text = Main.UserName;

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
        }
        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            if (e.SeriesPoint.Argument == "Today")
            {
                e.SeriesDrawOptions.Color = Color.FromArgb(221, 80, 68);
                e.LegendDrawOptions.Color = Color.Green;
            }
            else if (e.SeriesPoint.Argument == "Yesterday")
            {
                e.SeriesDrawOptions.Color = Color.FromArgb(49, 180, 46);
                e.LegendDrawOptions.Color = Color.Yellow;
            }
            else if (e.SeriesPoint.Argument == "Two Days Ago")
            {
                e.SeriesDrawOptions.Color = Color.FromArgb(0, 122, 204);
                e.LegendDrawOptions.Color = Color.Yellow;
            }
        }

        private void dateTime_Tick(object sender, EventArgs e)
        {

            lab_date.Text = DateTime.Now.ToString();
        }

        private void txt_OpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main.OnlyDigits(e);
        }

        private void btn_OpenCounter_Click(object sender, EventArgs e)
        {
            txt_OpeningBalance.Enabled = true;
            btn_Update.Enabled = true;
            btn_OpenCounter.Enabled = false;
            txt_OpeningBalance.Text = string.Empty;
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_OpeningBalance.Enabled = false;
            btn_Update.Enabled = false;
            btn_OpenCounter.Enabled = true;
            float OpeningBal = 0;// float.Parse(txt_OpeningBalance.Text);
            if (txt_OpeningBalance.Text == "")
            {
                MessageBox.Show("Please Enter Opening Amount");
            }
            else if (!float.TryParse(txt_OpeningBalance.Text, out OpeningBal))
            {
                MessageBox.Show("Unable To Get Amount", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult YorN = MessageBox.Show("Are You Sure To Update The Opening Balance", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    if (CheckTodayOpening() == true)
                    {
                        MessageBox.Show("Todays Counter Is Already Open. Do you Want To Update The Counter Value", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        SQL.NonScalarQuery("update dailycounter set DCOpBal =" + OpeningBal + " where DCDate=(select convert(date,GETDATE()))");
                    }
                    else
                    {
                        SQL.NonScalarQuery(@"Insert Into DailyCounter (DCDate,DCopBal,CompanyID)
                                                        values('" + DateTime.Now.ToString("yyyyMMdd") + "'," + OpeningBal + ","+Main.CompanyID+")");
                    }
                    MessageBox.Show("Balance Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DashboardUpdate_Tick(object sender, EventArgs e)
        {
            frm_Dashboard_Load(sender, e);
        }
    }
}
