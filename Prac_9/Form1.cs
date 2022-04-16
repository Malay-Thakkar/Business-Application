using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_a_bill
{
    public partial class Form1 : Form
    {
        int total = 0, i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                string[] nm = new string[5];
                int[] pr = new int[5];
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
                nm[0] = "Jalebi-fafda";
                pr[0] = 150;
                for (int i = 0; i < 1; i++)
                {
                    add_items(nm[i], pr[i]);
                }
            }
        }
        private void add_items(string name, int p)
        {
            ListViewItem l = new ListViewItem(name);
            l.SubItems.Add(p.ToString());
            listView1.Items.Add(l);
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(listView2.SelectedItems[0].SubItems[1].Text);
            int s = int.Parse(listView2.SelectedItems[0].SubItems[2].Text);
            total = total - (n * s);
            listView2.Items.Remove(listView2.SelectedItems[0]);
            label1.Text = total.ToString();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p, q,z;
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
            label1.Text = total.ToString();
            label1.Visible = true;
        }
    }
}
