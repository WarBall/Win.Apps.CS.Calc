using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Apps.CS.Calc
{
    public partial class SquareEquationForm : Form
    {
        public SquareEquationForm()
        {
            InitializeComponent();
        }

        
        private void btnResalt_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);

            double desk = MathemExpress.Deskr(a, b, c);

            if(desk < 0)
            {
                txtDecision.Text = "Дискриминант меньше нуля.";
            }
            else if (desk > 0)
            {
                double x1, x2, resalt;

                resalt = MathemExpress.SquareEquation(a, b, c, out x1, out x2);

                txt_X1.Text = "x1 = " + x1;
                txt_X2.Text = "x2 = " + x2;
            }
            else 
            {
                txt_X1.Text = "Корней нет";
                txt_X2.Text = "Корней нет";
            }
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }

        private void txt_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }
    }
}
