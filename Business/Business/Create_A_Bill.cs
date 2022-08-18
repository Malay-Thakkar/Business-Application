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

namespace Business
{
    public partial class Create_A_Bill : Form
    {
        double total = 0;
        int i = 0;
        public Create_A_Bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p, q, z;
            double gst = 0;
            string iname;
            p = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            q = int.Parse(numericUpDown1.Text);
            iname = listView1.SelectedItems[0].Text;
            listView2.Items.Add(iname);
            listView2.Items[i].SubItems.Add(p.ToString());
            listView2.Items[i].SubItems.Add(q.ToString());
            z = p * q;
            listView2.Items[i].SubItems.Add(z.ToString());
            i++;
            p = p * q;
            total = total + p;
            gst = (18 * total) / 100;
            total = total + gst;
            label8.Text = gst.ToString();
            label8.Visible = true;
            label9.Text = total.ToString();
            label9.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Create_A_Bill_Load(object sender, EventArgs e)
        {
            string[] nm = new string[10];
            int[] pr = new int[10];
            listView1.Columns.Add("Iteams");
            listView1.Columns.Add("Price");
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView2.Columns.Add("Iteams");
            listView2.Columns.Add("Price");
            listView2.Columns.Add("Quntity");
            listView2.Columns.Add("Cost");
            listView2.View = View.Details;
            listView2.GridLines = true;
            nm[0] = "Sendwich";
            pr[0] = 150;
            nm[1] = "Pizza";
            pr[1] = 120;
            nm[2] = "Burger";
            pr[2] = 70;
            nm[3] = "Dabeli";
            pr[3] = 15;
            nm[4] = "Vada-pau";
            pr[4] = 150;
            nm[5] = "Manchurian";
            pr[5] = 90;
            nm[6] = "Bhaji-Pau";
            pr[6] = 100;
            nm[7] = "Coffe";
            pr[7] = 150;
            nm[8] = "Tea";
            pr[8] = 50;

            for (int i = 0; i < 8; i++)
            {
                add_items(nm[i], pr[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Create_A_Bill bill = new Create_A_Bill();
            bill.Show();
        }
        private void add_items(string name, int p)
        {
            ListViewItem l = new ListViewItem(name);
            l.SubItems.Add(p.ToString());
            listView1.Items.Add(l);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    if (listView2.Items[i].Selected)
                    {
                        listView2.Items[i].Remove();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {

               try
                {
                    string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\C# application\final project\Business\Business\Invoice.mdf;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(ConnectionString);
                    SqlCommand command = connection.CreateCommand();

                    connection.Open();
                    string invoiceid = textBox2.Text;
                    command.CommandText = "Insert into Invoice_master (Name,Invoice_Date,Total_amount,Paid_amount) values('" + textBox1.Text + "',getdate(),'" + label9.Text + "','" + textBox3.Text + "'); select scope_identity();";

                    string InvoiceID = command.ExecuteScalar().ToString();


                    foreach (ListViewItem ListItem in listView2.Items)
                    {

                    command.CommandText = "Insert into Invoice_detail(master_id,item_name,item_price,item_qty,item_total) values('"+InvoiceID+"', '" + ListItem.SubItems[0].Text + "', '" + ListItem.SubItems[1].Text + "', '" + ListItem.SubItems[2].Text + "' , '" + ListItem.SubItems[3].Text + "');";

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    
                    MessageBox.Show("Sale Created Successfully, with Invoice # " + InvoiceID);
                    //new Report.PrintInvoiceForm(InvoiceID).Show();
              }
                catch (Exception ee)
                {
                   MessageBox.Show("Sale Not Created, Error!");
                }

            }
            else
            {
                MessageBox.Show("Must Add an Item in the List");
            }
        }
    }
}