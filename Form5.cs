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
using System.Windows.Forms.VisualStyles;

namespace TrainTicketBookingSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string USERID=textBox1.Text;


            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Details");
                }
                else
                {
                    string query = "SELECT * FROM Table_2 WHERE USERID= '" + textBox1.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
            finally { con.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String USER = textBox1.Text;
            try
            {
                string query="SELECT * FROM Table_2 WHERE USERID= '"+ textBox1.Text +"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    string query1 = "DELETE  FROM Table_2 WHERE USERID= '" + textBox1.Text + "' ";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    MessageBox.Show("TICKET SUCCESSFULL CANCELED\nREFUND WILL BE SEND IN 2-3 WORKING DAYS");
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                  
                }
                else
                {
                    MessageBox.Show("NO TICKETS  BOOKED BY THE USER!!");
                    textBox1.Clear();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally { con.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
