namespace At_yarışı
{
    public partial class Form1 : Form
    {
        string kuladı;
        string şifre;

        public Form1()
        {
            InitializeComponent();
             kuladı=textBox1.Text;
           şifre = textBox2.Text;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2aç = new Form2();
            form2aç.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
