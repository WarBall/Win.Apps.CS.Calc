using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace Win.Apps.CS.Calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            txtOutput.Text = "0";
        }

        #region Constants
        private const string odin = "1";
        private const string dva = "2";
        private const string tri = "3";
        private const string chetire = "4";
        private const string pyat = "5";
        private const string shest = "6";
        private const string sem = "7";
        private const string vosem = "8";
        private const string devyat = "9";
        private const string nul = "0";
        #endregion
       
        private void btn1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(odin);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(dva);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(tri);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(chetire);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(pyat);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(shest);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(sem);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(vosem);
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(devyat);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(nul);
        }

        private void btnChangesign_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
        }
        
        private void btn_delenie_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Delenie);
        }

        private void btn_umnojenie_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Umnojenie);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Vichitanie);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Slojenie);
        }

        private void btn_ravno_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn_sbros_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.Sbros();
            txtOutput.Text = "0";
        }

        private void btn_exponentiation_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Exponentiation);
        }

        private void btn_squareRoot_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.SquareRoot);
            txtOutput.Text = mehanizmcalkulyatora.SinglePressing();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn_regressiveNum_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.RegressiveNum);
            txtOutput.Text = mehanizmcalkulyatora.SinglePressing();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn_squareNum_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.SquareNumber);
            txtOutput.Text = mehanizmcalkulyatora.SinglePressing();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.bLogarithm);           
        }

        private void btn_fact_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Factorial);
            txtOutput.Text = mehanizmcalkulyatora.SinglePressing();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn_CubRoot_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.CubicRoot);
            txtOutput.Text = mehanizmcalkulyatora.SinglePressing();
            mehanizmcalkulyatora.Sbros();
        }

        private void engineeringMenuItem_Click(object sender, EventArgs e)
        {
            EngineeringСalcBox.Visible = true;
            RegularСalcBox.Visible = false;
        }

        private void normViewMenuItem_Click(object sender, EventArgs e)
        {
            EngineeringСalcBox.Visible = false;
            RegularСalcBox.Visible = true;
        }
    }
}
