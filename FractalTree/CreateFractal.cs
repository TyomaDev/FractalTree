using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class CreateFractal : Form
    {
        public CreateFractal()
        {
            InitializeComponent();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.MediumVioletRed;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.MediumVioletRed;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }



        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.MediumVioletRed;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.MediumVioletRed;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.MediumVioletRed;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateFractal_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            about about = new about();
            about.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Reference reference = new Reference();
            reference.Show();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
