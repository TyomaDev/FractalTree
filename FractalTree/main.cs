namespace FractalTree
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.MediumVioletRed;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.MediumVioletRed;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

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

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.MediumVioletRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateFractal createFractal = new CreateFractal();
            createFractal.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateFractal createFractal = new CreateFractal();
            createFractal.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            about about = new about();
            about.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Reference reference = new Reference();
            reference.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}