namespace MODUL3_1302213050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Numb;
        int Sum;
        private void Hasil_Click(object sender, EventArgs e)
        {
            Sum = Numb + int.Parse(label1.Text);
            label1.Text = Sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numb = int.Parse(label1.Text);
            label1.Text = label1.Text + "+";
            label1.Text = "";
        }

        private void Angka0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void Angka1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void Angka2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void Angka3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void Angka4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void Angka5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void Angka6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void Angka7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void Angka8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void Angka9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}