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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            string SOURCE, DEST;
            SOURCE=comboBox1.Text;
            DEST=comboBox2.Text;
            try
            {
                string query = "SELECT * FROM Train_info where Source= '" + comboBox1.Text + "' AND Destination= '" + comboBox2.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s, d, t;
            s = comboBox1.Text;
            d = comboBox2.Text;
            t = textBox1.Text;



                if (t == "")
                {
                    MessageBox.Show("Enter Train no.");
                }
                else
                { 

                 
                    this.Hide();
                    Form7 f = new Form7();
                    f.ShowDialog();
                }
               
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
