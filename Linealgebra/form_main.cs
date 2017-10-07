using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linealgebra
{
    public partial class form_main : Form
    {
      
        public form_main()
        {
            InitializeComponent();
        }
        private void form_main_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_addsub_Click(object sender, EventArgs e)
        {
            form_addsub frm_addsub = new form_addsub();
            frm_addsub.Show();
        }

        private void btn_determinant_Click(object sender, EventArgs e)
        {
            form_determinant frm_determinant = new form_determinant();
            frm_determinant.Show();
        }

        private void btn_transpose_Click(object sender, EventArgs e)
        {
            form_transpose frm_transpose = new form_transpose();
            frm_transpose.Show();
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            form_power frm_power = new form_power();
            frm_power.Show();
        }

        private void btn_gauss_Click(object sender, EventArgs e)
        {
            form_gauss frm_gauss = new form_gauss();
            frm_gauss.Show();
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            form_multiplication frm_multiplication = new form_multiplication();
            frm_multiplication.Show();
        }

        private void btn_eigenvectors_Click(object sender, EventArgs e)
        {
            form_eigenvectors frm_eigenvectors = new form_eigenvectors();
            frm_eigenvectors.Show();
        }

        private void btn_inverse_Click(object sender, EventArgs e)
        {
            form_inverse frm_inverse = new form_inverse();
            frm_inverse.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            form_info frm_info = new form_info();
            frm_info.Show();
        }
    }
}
