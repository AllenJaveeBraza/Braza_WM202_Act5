using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braza_WM202_Act5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            EmployN.Clear();
            Dept.Clear();
            BIrph.Clear();
            BINoHC.Clear();
            BIinCO.Clear();
            HIRph.Clear();
            HINoHC.Clear();
            HIinCO.Clear();
            OIRph.Clear();
            OINoHC.Clear();
            OIinCO.Clear();
            SIGI.Clear();
            SINI.Clear();
            FirN.Clear();
            MidN.Clear();
            SurN.Clear();
            CivS.Clear();
            QDS.Clear();
            PayD.Clear();
            EmS.Clear();
            Desg.Clear();
            SSSCon.Clear();
            PHCon.Clear();
            PIgCon.Clear();
            ITCon.Clear();
            SSSLoan.Clear();
            PIgLoan.Clear();
            FSDep.Clear();
            FSLoan.Clear();
            SalLoan.Clear();
            OtherLoan.Clear();
            TotalDeduc.Clear();
        }

        private void GrossInc_Click(object sender, EventArgs e)
        {
            double BIrph_v, BINoHC_v, HIRph_v, HINoHC_v, OIRph_v, OINoHC_v;

            double.TryParse(BIrph.Text, out BIrph_v);
            double.TryParse(BINoHC.Text, out BINoHC_v);
            double BasicIncome = Math.Round(BIrph_v * BINoHC_v, 2);
            BIinCO.Text = BasicIncome.ToString();

            double.TryParse(HIRph.Text, out HIRph_v);
            double.TryParse(HINoHC.Text, out HINoHC_v);
            double HonorIncome = Math.Round(HIRph_v * HINoHC_v, 2);
            HIinCO.Text = HonorIncome.ToString();

            double.TryParse(OIRph.Text, out OIRph_v);
            double.TryParse(OINoHC.Text, out OINoHC_v);
            double OtherIncome = Math.Round(OIRph_v * OINoHC_v, 2);
            OIinCO.Text = OtherIncome.ToString();

            double gross = BasicIncome + HonorIncome + OtherIncome;
            SIGI.Text = gross.ToString();

            




        }

        private void BIrph_TextChanged(object sender, EventArgs e)
        {

        }

        private void NetInc_Click(object sender, EventArgs e)
        {
            double gross;
            double.TryParse(SIGI.Text, out gross);

            // --- PhilHealth Contribution (PHC) ---
            double PHC = 0.0;
            if (gross <= 10000) PHC = 137.50;
            else if (gross <= 11000) PHC = 151.25;
            else if (gross <= 12000) PHC = 165.00;
            else if (gross <= 13000) PHC = 178.75;
            else if (gross <= 14000) PHC = 192.50;
            else if (gross <= 15000) PHC = 206.25;
            else if (gross <= 16000) PHC = 220.00;
            else if (gross <= 17000) PHC = 233.75;
            else if (gross <= 18000) PHC = 247.50;
            else if (gross <= 19000) PHC = 261.25;
            else if (gross <= 20000) PHC = 275.00;
            else if (gross <= 21000) PHC = 288.75;
            else if (gross <= 22000) PHC = 302.50;
            else if (gross <= 23000) PHC = 316.25;
            else if (gross <= 24000) PHC = 330.00;
            else if (gross <= 25000) PHC = 343.75;
            else if (gross <= 26000) PHC = 357.50;
            else if (gross <= 27000) PHC = 371.25;
            else if (gross <= 28000) PHC = 385.00;
            else if (gross <= 29000) PHC = 398.75;
            else if (gross <= 30000) PHC = 412.50;
            else if (gross <= 31000) PHC = 426.25;
            else if (gross <= 32000) PHC = 440.00;
            else if (gross <= 33000) PHC = 453.75;
            else if (gross <= 34000) PHC = 467.50;
            else if (gross <= 35000) PHC = 481.25;
            else if (gross <= 36000) PHC = 495.00;
            else if (gross <= 37000) PHC = 508.75;
            else if (gross <= 38000) PHC = 522.50;
            else if (gross <= 39000) PHC = 536.25;
            else if (gross <= 39999.99) PHC = 543.13;
            else PHC = 550.00;
            PHCon.Text = PHC.ToString();

            // --- SSS Contribution (SSSC) ---
            double SSSC = 0.0;
            if (gross < 1000) SSSC = 0.00;
            else if (gross <= 1249.99) SSSC = 36.30;
            else if (gross <= 1749.99) SSSC = 54.50;
            else if (gross <= 2249.99) SSSC = 72.70;
            else if (gross <= 2749.99) SSSC = 90.80;
            else if (gross <= 3249.99) SSSC = 109.00;
            else if (gross <= 3749.99) SSSC = 127.20;
            else if (gross <= 4249.99) SSSC = 145.30;
            else if (gross <= 4749.99) SSSC = 163.50;
            else if (gross <= 5249.99) SSSC = 181.70;
            else if (gross <= 5749.99) SSSC = 199.80;
            else if (gross <= 6249.99) SSSC = 218.00;
            else if (gross <= 6749.99) SSSC = 236.29;
            else if (gross <= 7249.99) SSSC = 254.30;
            else if (gross <= 7749.99) SSSC = 272.50;
            else if (gross <= 8249.99) SSSC = 290.70;
            else if (gross <= 8749.99) SSSC = 308.80;
            else if (gross <= 9249.99) SSSC = 327.00;
            else if (gross <= 9749.99) SSSC = 345.20;
            else if (gross <= 10249.99) SSSC = 363.30;
            else if (gross <= 10749.99) SSSC = 381.50;
            else if (gross <= 11249.99) SSSC = 399.70;
            else if (gross <= 11749.99) SSSC = 417.80;
            else if (gross <= 12249.99) SSSC = 436.00;
            else if (gross <= 12749.99) SSSC = 454.20;
            else if (gross <= 13249.99) SSSC = 472.30;
            else if (gross <= 13749.99) SSSC = 490.50;
            else if (gross <= 14249.99) SSSC = 508.70;
            else if (gross <= 14749.99) SSSC = 526.80;
            else if (gross <= 15249.99) SSSC = 545.00;
            else if (gross <= 15749.99) SSSC = 563.20;
            SSSCon.Text = SSSC.ToString();

            // --- Income Tax (ITC) ---
            double ITC = 0.0;
            if (gross < (250000 / 24.0))
            {
                ITC = 581.30;
            }
            else if (gross > 10416.67 && gross <= 16666.67)
            {
                ITC = (((gross * 24) - 250000) * 0.20 / 24);
            }
            else if (gross > 16666.67 && gross <= 33333.33)
            {
                ITC = (((gross * 24) - 400000) * 0.25 + 30000) / 24;
            }
            else if (gross > 33333.33 && gross <= 83333.33)
            {
                ITC = (((gross * 24) - 800000) * 0.30 + 130000) / 24;
            }
            else if (gross > 83333.33 && gross <= 333333.33)
            {
                ITC = (((gross * 24) - 2000000) * 0.32 + 490000) / 24;
            }
            else
            {
                ITC = (((gross * 24) - 8000000) * 0.35 + 2410000) / 24;
            }
            ITCon.Text = ITC.ToString("N2");

            // --- Pagibig Contribution (fixed) ---
            double pigCon = 200.00;
            PIgCon.Text = pigCon.ToString();

            // --- Loans ---
            double sssLoan_v, pigLoan_v, fsDep_v, fsLoan_v, salLoan_v, otherLoan_v;
            double.TryParse(SSSLoan.Text, out sssLoan_v);
            double.TryParse(PIgLoan.Text, out pigLoan_v);
            double.TryParse(FSDep.Text, out fsDep_v);
            double.TryParse(FSLoan.Text, out fsLoan_v);
            double.TryParse(SalLoan.Text, out salLoan_v);
            double.TryParse(OtherLoan.Text, out otherLoan_v);

            double totalDeductions = Math.Round(SSSC + PHC + pigCon + ITC + sssLoan_v + pigLoan_v + fsDep_v + fsLoan_v + salLoan_v + otherLoan_v, 2);
            TotalDeduc.Text = totalDeductions.ToString();

            double netIncome = gross - totalDeductions;
            SINI.Text = Math.Round(netIncome, 2).ToString();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            double gross, phCon, sssCon, pigCon, itCon, totalDeductions, netIncome;
            double basicPay, overtime, honorarium;
            double honorAdj, substitution, tardy, wispCon, wholdTax;

            
            double.TryParse(SIGI.Text, out gross);
            double.TryParse(PHCon.Text, out phCon);
            double.TryParse(SSSCon.Text, out sssCon);
            double.TryParse(PIgCon.Text, out pigCon);
            double.TryParse(ITCon.Text, out itCon);
            double.TryParse(TotalDeduc.Text, out totalDeductions);
            double.TryParse(SINI.Text, out netIncome);

            double.TryParse(BIinCO.Text, out basicPay);
            double.TryParse(OIinCO.Text, out overtime);
            double.TryParse(HIinCO.Text, out honorarium);

            
            honorAdj = 0;
            substitution = 0;
            tardy = 0;
            wispCon = 0;
            wholdTax = itCon; 

            
            string company = "Lyceum of the Philippines University Cavite";
            string employeeNumber = EmployN.Text;
            string employeeName = SurN.Text + ", " + FirN.Text + " " + MidN.Text;
            string department = Dept.Text;
            string cutOff = PayD.Text;
            string payPeriod = PayD.Text;

            
            PaymentSlip slip = new PaymentSlip(company, employeeNumber, employeeName,
                                               department, cutOff, payPeriod,
                                               basicPay, overtime, honorarium,
                                               honorAdj, substitution, tardy,
                                               gross, totalDeductions, netIncome,
                                               itCon, sssCon, pigCon, phCon, wispCon,
                                               wholdTax);
            slip.ShowDialog();
        }
    }
}
