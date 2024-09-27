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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                string USERID, PASS1, PASS2;
                USERID = textBox1.Text;
                PASS1 = textBox2.Text;
                PASS2 = textBox3.Text;
                try
                {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Enter Details");
                }
                else
                {
                    if (PASS1 == PASS2)
                    {
                        string query = "INSERT INTO SIGN_IN values('" + textBox1.Text + "','" + textBox2.Text + "')";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        USERID = textBox1.Text;
                        PASS1 = textBox2.Text;
                        MessageBox.Show("ACCOUNT CREATED SUCESSFULLY");
                        Form1 f = new Form1();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("PASSWORD DOES NOT MATCH");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("ERROR IN REGISTERING");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show password";

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Hide password";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
