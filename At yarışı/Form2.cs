﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarışı
{
    public partial class Form2 : Form
    {
        int zaman = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman++;
             if (zaman == 2)
            {
                
                   timer1.Stop();  
                   Form3 form3aç = new Form3();
                   form3aç.Show();
                   this.Hide();
            }
        }
    }
}
