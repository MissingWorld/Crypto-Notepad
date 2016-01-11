﻿using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class ChangeKeyForm : Form
    {
        public ChangeKeyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == MainWindow.key)
            {
                MainWindow.key = textBox2.Text;
                MainWindow.keyChanged = true;
                this.Close();
            }

            else if (textBox1.Text != MainWindow.key)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Wrong old key!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.eye_half;
                return;
            }

            if (textBox1.UseSystemPasswordChar == false)
            {
                textBox1.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.eye;
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.eye_half;
                return;
            }

            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.eye;
                return;
            }
        }

        private void ChangeKeyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
