using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketBookingSystem
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
