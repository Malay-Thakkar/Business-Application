using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.Name = Name;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            label3.Text = Name;
            label3.ForeColor = Color.Gold;
        }

        private void createABillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_A_Bill bill = new Create_A_Bill();
            bill.Show();
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculater = new Calculator();
            calculater.Show();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad notes = new Notepad();
            notes.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = @"How to use the application? 
(1) LOg IN to application user Name:Malay password:2002 image
(2) There are many options. select according to your choice.image
(1) create a bill: where you can make a bill save a bill as well as you can print the bill.
image
(2) calculator: this is simple function were you calculate.
image
(3) Notes: it is the same as notepad.there are many functions in the notepad.
image
(4) Deposite & Borrow: There you can make notes of how to give advance payment or who did not give payment.
(5) Help: that provide helps REgarding application.";
            string title = "Help";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void depositBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "That function is in Maintenance";
            string title = "Deposit & Borrow";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
