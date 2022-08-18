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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\C# application\final project\Business\Business\login.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            string a = "insert into login(username,password) values('" + textBox1.Text + "','" + textBox2.Text + "');";
            SqlCommand cmd = new SqlCommand(a,cn);
            cmd.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("Try again you got error");
            }
            cn.Close();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
