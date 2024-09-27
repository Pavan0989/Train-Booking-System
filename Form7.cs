using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrainTicketBookingSystem
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string USERID, NAME, AGE, GEN;
            USERID=textBox6.Text;
            NAME=textBox1.Text;
            AGE=textBox2.Text;
            GEN=textBox3.Text;
            if (USERID != "" && NAME != "" && AGE != "" && GEN != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Table_2 (USERID,NAME,AGE,GEN) VALUES ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    USERID = textBox6.Text;
                    NAME = textBox1.Text;
                    AGE = textBox2.Text;
                    GEN = textBox3.Text;
                    MessageBox.Show(" PASSENGER ADDED SUCESSFULLY");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("ENTER PASSENGER DETAILS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TICKET HAS BEEN SUCESSFULLY BOOKED\nTICKET DETAILS HAS BEEN SEND TO CONTACT DETAILS");
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }
    }
}
