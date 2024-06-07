using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarışı
{
    public partial class Form3 : Form
    {
        public int atseçildimi = 0 ;
        public int başlangıçbakiye = 100 ;
        public int kazananatnumara = 0 ;
        public bool kaybettimi = false; 

        public Form3()
        {
            InitializeComponent();
            button1.Enabled = false;
            pictureBox1.Enabled = false;  // başlangıçta hepsini durgun yapar 
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            label6.Text = "Yarış başlaması için at seçiniz ";

            birinciatınsolauzaklık = pictureBox1.Left;
            ikinciatınsolauzaklık = pictureBox2.Left;
            ucuncuatınsolauzaklık = pictureBox3.Left;

        }

        int birinciatınsolauzaklık, ikinciatınsolauzaklık, ucuncuatınsolauzaklık;

        Random rasgeleuzaklık = new Random();

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button1.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            int genişliğiat1 = pictureBox1.Width;
            int genişliğiat2 = pictureBox2.Width;
            int genişliği3 = pictureBox3.Width;

            int bitişuzaklığı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rasgeleuzaklık.Next(5, 10);
            pictureBox2.Left = pictureBox2.Left + rasgeleuzaklık.Next(5, 10);
            pictureBox3.Left = pictureBox3.Left + rasgeleuzaklık.Next(5, 10);


            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Bir numaralı at önde  ";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "İki numaralı at önde götürüyor  ";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "üç numaralı at önde götürüyor  ";
            }





            if (genişliğiat1 + pictureBox1.Left >= bitişuzaklığı)
            {
                label6.Text = " BİR NUMARALI AT YARIŞI KAZANDI ";

                button1.Enabled = true;
                button1.BackColor = Color.Aquamarine;
                timer1.Stop();
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                kazananatnumara = 1;
            }
            if (genişliğiat2 + pictureBox2.Left >= bitişuzaklığı)
            {
                label6.Text = " İKİ NUMARALI AT YARIŞI KAZANDI ";

                button1.Enabled = true;
                button1.BackColor = Color.Aquamarine;
                timer1.Stop();
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                kazananatnumara = 2;
            }
            if (genişliği3 + pictureBox3.Left >= bitişuzaklığı)
            {
                label6.Text = " ÜÇ NUMARALI AT YARIŞI KAZANDI ";

                button1.Enabled = true;
                button1.BackColor = Color.Aquamarine;
                timer1.Stop();
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                kazananatnumara = 3;

            }
            if (kazananatnumara == atseçildimi)
            {
                başlangıçbakiye = başlangıçbakiye + 10;
                label9.Text = Convert.ToString(başlangıçbakiye);

            }
            else if (kazananatnumara != atseçildimi)
            {

                
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            atseçildimi = 1;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;

            atseçildimi = 2;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;

            atseçildimi = 3;

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
}
