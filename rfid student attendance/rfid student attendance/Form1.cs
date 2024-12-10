using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rfid_student_attendance
{
    public partial class Form1 : Form
    {
        int ImageNumber = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ImageNumber == 4)
            {
                ImageNumber = 2;
            }
            pictureBox2.ImageLocation = String.Format(@"image\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();

            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
