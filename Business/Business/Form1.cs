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

namespace Business
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter UserName");
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\C# application\final project\Business\Business\login.mdf;Integrated Security=True";
                SqlConnection obj = new SqlConnection(con);
                string sql = "select username, password from login where username = '" + textBox1.Text + "'and password = '" + textBox2.Text + "';";
                SqlCommand cmd = new SqlCommand(sql, obj);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    menu m = new menu();
                    m.Name = textBox1.Text;
                    m.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                obj.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup m = new signup();
            m.Show();
            this.Hide();
        }
    }
}
