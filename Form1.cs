
using System.Data;
using System.Data.SqlClient;


namespace TrainTicketBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Pavan\SQLEXPRESS;Initial Catalog=PK09;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            string USERNAME, PASSWORD;
            USERNAME = textBox1.Text;
            PASSWORD = textBox2.Text;
            try
            {
                if (textBox1.Text== "" || textBox2.Text=="")
                {
                    MessageBox.Show("Enter Details");
                }
                else
                {
                    string query = "SELECT * FROM SIGN_IN WHERE USERID= '" + textBox1.Text + "' AND PASSWORD= '" + textBox2.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        USERNAME = textBox1.Text;
                        PASSWORD = textBox2.Text;
                        MessageBox.Show("LOGIN SUCCESSFULL");
                        Form3 form = new Form3();
                        form.ShowDialog();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
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
        private void button4_Click(object sender, EventArgs e)
        {
            string USERNAME, PASSWORD;
            USERNAME = textBox1.Text;
            PASSWORD = textBox2.Text;
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Enter Details");
                }
                else
                {
                    string query = "SELECT * FROM SIGN_IN WHERE USERID= '" + textBox1.Text + "' AND PASSWORD= '" + textBox2.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        USERNAME = textBox1.Text;
                        PASSWORD = textBox2.Text; 
                        Form6 form = new Form6();
                        form.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}