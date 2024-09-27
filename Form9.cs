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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string USERID, PASSWORD;
            USERID = textBox1.Text;
            PASSWORD = textBox2.Text;
            try
            {
                string query = "SELECT * FROM SIGN_IN WHERE USERID= '"+textBox1.Text+"' AND PASSWORD= '"+textBox2.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               if (dt.Rows.Count > 0)
                {
                    string query1= "DELETE FROM SIGN_IN WHERE USERID= '"+ textBox1.Text +"' AND PASSWORD= '"+ textBox2.Text +"'";
                    SqlDataAdapter adapter1=new SqlDataAdapter(query1, con);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    MessageBox.Show("Account Deleted Successfully");
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                   
                }
               else
                {
                    MessageBox.Show("ACCOUNT DOES NOT EXIST");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show Password";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Hide Password";
            }
        }
    }
}
