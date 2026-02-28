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
            double BIrph_v;
            double BINoHC_v;
            double HIRph_v;
            double HINoHC_v;
            double OIRph_v;
            double OINoHC_v;

            double.TryParse(BIrph.Text, out BIrph_v);
            double.TryParse(BINoHC.Text, out BINoHC_v);
            double BasicTotal = BIrph_v * BINoHC_v;
            double BasicIncome = Math.Round(BasicTotal, 2);
            BIinCO.Text = (BasicIncome).ToString();

            double.TryParse(HIRph.Text, out HIRph_v);
            double.TryParse(HINoHC.Text, out HINoHC_v);
            double HonorTotal = HIRph_v * HINoHC_v;
            double HonorIncome = Math.Round(HonorTotal, 2);
            HIinCO.Text = (HonorIncome).ToString();

            double.TryParse(OIRph.Text, out OIRph_v);
            double.TryParse(OINoHC.Text, out OINoHC_v);
            double OtherTotal = OIRph_v * OINoHC_v;
            double OtherIncome = Math.Round(OtherTotal, 2);
            OIinCO.Text = (OtherIncome).ToString();


        
        
        
        
        }

        private void BIrph_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
