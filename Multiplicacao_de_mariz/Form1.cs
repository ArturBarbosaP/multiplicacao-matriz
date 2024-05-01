using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicacao_de_mariz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            int a11, a12, a13, a21, a22, a23, a31, a32, a33, b11, b12, b13, b21, b22, b23, b31, b32, b33;

            a11 = int.Parse(txt_A11.Text);
            a12 = int.Parse(txt_A12.Text);
            a13 = int.Parse(txt_A13.Text);
            a21 = int.Parse(txt_A21.Text);
            a22 = int.Parse(txt_A22.Text);
            a23 = int.Parse(txt_A23.Text);
            a31 = int.Parse(txt_A31.Text);
            a32 = int.Parse(txt_A32.Text);
            a33 = int.Parse(txt_A33.Text);

            b11 = int.Parse(txt_B11.Text);
            b12 = int.Parse(txt_B12.Text);
            b13 = int.Parse(txt_B13.Text);
            b21 = int.Parse(txt_B21.Text);
            b22 = int.Parse(txt_B22.Text);
            b23 = int.Parse(txt_B23.Text);
            b31 = int.Parse(txt_B31.Text);
            b32 = int.Parse(txt_B32.Text);
            b33 = int.Parse(txt_B33.Text);

            txt_R11.Text = (a11 * b11) + (a12 * b21) + (a13 * b31) + "";
            txt_R12.Text = (a11 * b12) + (a12 * b22) + (a13 * b32) + "";
            txt_R13.Text = (a11 * b13) + (a12 * b23) + (a13 * b33) + "";
            txt_R21.Text = (a21 * b11) + (a22 * b21) + (a23 * b31) + "";
            txt_R22.Text = (a21 * b12) + (a22 * b22) + (a23 * b32) + "";
            txt_R23.Text = (a21 * b13) + (a22 * b23) + (a23 * b33) + "";
            txt_R31.Text = (a31 * b11) + (a32 * b21) + (a33 * b31) + "";
            txt_R32.Text = (a31 * b12) + (a32 * b22) + (a33 * b32) + "";
            txt_R33.Text = (a31 * b13) + (a32 * b23) + (a33 * b33) + "";

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_A11.Clear();
            txt_A12.Clear();
            txt_A13.Clear();
            txt_A21.Clear();
            txt_A22.Clear();
            txt_A23.Clear();
            txt_A31.Clear();
            txt_A32.Clear();
            txt_A33.Clear();

            txt_B11.Clear();
            txt_B12.Clear();
            txt_B13.Clear();
            txt_B21.Clear();
            txt_B22.Clear();
            txt_B23.Clear();
            txt_B31.Clear();
            txt_B32.Clear();
            txt_B33.Clear();

            txt_R11.Clear();
            txt_R12.Clear();
            txt_R13.Clear();
            txt_R21.Clear();
            txt_R22.Clear();
            txt_R23.Clear();
            txt_R31.Clear();
            txt_R32.Clear();
            txt_R33.Clear();
        }
    }
}
