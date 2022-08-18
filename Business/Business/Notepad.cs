using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Business
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = " ";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "D:";
            op.Filter = "Text Documents (.txt)|.txt | All Files (.)|.";
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(op.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                sr.Close();
                fs.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); sfd.Title = "Save";
            sfd.Filter = "TXT Files|*.txt";
            sfd.DefaultExt = ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName);
                this.Text = sfd.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "I Am in lerning stage now So i can't help lern your self";
            string tittle = "Help";
            MessageBox.Show(message,tittle,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            //fd.ShowColor = true;
            fd.Font = richTextBox1.SelectionFont;
            //fd.Color = richTextBox1.SelectionColor;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;
            cd.AnyColor = true;
            cd.SolidColorOnly = false;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void Notepad_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
