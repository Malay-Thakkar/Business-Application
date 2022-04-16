using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busyness
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public main(string Name)
        {
            InitializeComponent();
            this.Name = Name;
        }

        public string Name { get; set; }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {   
          
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Hello, i am in lerning fase so i can't help you";
            string title = "Help";
            MessageBox.Show(message, title,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad.Form1 Note = new Notepad.Form1();
            Note.Show();
        }

        private void createABillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_a_bill.Form1 bill = new Create_a_bill.Form1();
            bill.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            label3.Text = Name;
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }

        private void depositBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "That function is in Maintenance";
            string title = "Deposit & Borrow";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
