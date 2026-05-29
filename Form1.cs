using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt___Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            btn1.Parent = pictureBox1;
            btn1.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            btnTYas2.Visible = true;
            btnTNo3.Visible = true;
            btn1.Visible=false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form TextToText = new TextToText();
            TextToText.ShowDialog();
            this.Visible = true;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            btnBNO4.Visible = true;
            btnBYas5.Visible = true;
            label3.Visible=false;
            btnTYas2.Visible=false;
            btnTNo3.Visible=false; 
        }

        private void btnNO4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBYas5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form TextToBinary = new TextToBinary();
            TextToBinary.ShowDialog();
            this.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
