using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketBookingSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string USERID, PASS1, PASS2;
            USERID = textBox1.Text;
            PASS1 = textBox2.Text;
            PASS2 = textBox3.Text;  
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE SIGN_IN SET PASSWORD= '" + PASS1 + "' WHERE USERID='" + USERID + "'";
            try
            {
                if(PASS1 == PASS2)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PASSWORD HAS BEEN CHANGED SUCESSFULLY");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("PASSWORDS DOESNT MATCH\nRE-ENTER");
                }
            }
            catch
            {
                MessageBox.Show("ACCOUNT DOES NOT EXIST");
            }
            finally
            {
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
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
    }
}
