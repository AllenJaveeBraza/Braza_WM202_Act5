using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braza_WM202_Act5
{
    public partial class PaymentSlip : Form
    {
        public PaymentSlip(string company, string employeeCode, string employeeName,
                   string department, string cutOff, string payPeriod,
                   double basicPay, double overtime, double honorarium,
                   double honorAdj, double substitution, double tardy,
                   double gross, double totalDeductions, double netIncome,
                   double itCon, double sssCon, double pigCon, double phCon, double wispCon,
                   double wholdTax)
        {

            InitializeComponent();

            Company.Text = company;
            EmployCode.Text = employeeCode;
            EmployName.Text = employeeName;
            Dept.Text = department;
            Cutoff.Text = cutOff;
            PayPeriod.Text = payPeriod;

            // Earnings
            BPDoH.Text = basicPay.ToString("N2");
            OTDoH.Text = overtime.ToString("N2");
            HDoH.Text = honorarium.ToString("N2");
            HADoH.Text = honorAdj.ToString("N2");
            SUBDoH.Text = substitution.ToString("N2");
            Tardy.Text = tardy.ToString("N2");

            // Totals
            EarnTotal.Text = gross.ToString("N2");
            DeducTotal.Text = totalDeductions.ToString("N2");
            OTTotal.Text = overtime.ToString("N2");
            GrossEarn.Text = gross.ToString("N2");
            Deduc.Text = totalDeductions.ToString("N2");
            NetPay.Text = netIncome.ToString("N2");

            // Deductions
            WholdTax.Text = wholdTax.ToString("N2");
            SSScon.Text = sssCon.ToString("N2");
            PIgcon.Text = pigCon.ToString("N2");
            PhCon.Text = phCon.ToString("N2");
            WISPCon.Text = wispCon.ToString("N2");
        }

        private void PaymentSlip_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void BPDoH_Click(object sender, EventArgs e)
        {

        }

        private void Company_Click(object sender, EventArgs e)
        {

        }

        private void EmployCode_Click(object sender, EventArgs e)
        {

        }

        private void EmployName_Click(object sender, EventArgs e)
        {

        }

        private void Dept_Click(object sender, EventArgs e)
        {

        }

        private void Cutoff_Click(object sender, EventArgs e)
        {

        }

        private void PayPeriod_Click(object sender, EventArgs e)
        {

        }

        private void EarnTotal_Click(object sender, EventArgs e)
        {

        }

        private void DeducTotal_Click(object sender, EventArgs e)
        {

        }

        private void OTTotal_Click(object sender, EventArgs e)
        {

        }

        private void GrossEarn_Click(object sender, EventArgs e)
        {

        }

        private void Deduc_Click(object sender, EventArgs e)
        {

        }

        private void NetPay_Click(object sender, EventArgs e)
        {

        }

        private void OTDoH_Click(object sender, EventArgs e)
        {

        }

        private void HDoH_Click(object sender, EventArgs e)
        {

        }

        private void HADoH_Click(object sender, EventArgs e)
        {

        }

        private void SUBDoH_Click(object sender, EventArgs e)
        {

        }

        private void Tardy_Click(object sender, EventArgs e)
        {

        }

        private void DPTax_Click(object sender, EventArgs e)
        {

        }

        private void OTTax_Click(object sender, EventArgs e)
        {

        }

        private void HonorTax_Click(object sender, EventArgs e)
        {

        }

        private void HATax_Click(object sender, EventArgs e)
        {

        }

        private void SubTax_Click(object sender, EventArgs e)
        {

        }

        private void BPNonT_Click(object sender, EventArgs e)
        {

        }

        private void OTNonT_Click(object sender, EventArgs e)
        {

        }

        private void HonorNonT_Click(object sender, EventArgs e)
        {

        }

        private void SUBNonT_Click(object sender, EventArgs e)
        {

        }

        private void WholdTax_Click(object sender, EventArgs e)
        {

        }

        private void SSScon_Click(object sender, EventArgs e)
        {

        }

        private void PIgcon_Click(object sender, EventArgs e)
        {

        }

        private void PhCon_Click(object sender, EventArgs e)
        {

        }

        private void WISPCon_Click(object sender, EventArgs e)
        {

        }
    }
}
