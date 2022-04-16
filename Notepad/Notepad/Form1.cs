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
namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "I Am in lerning stage now So i can't help lern your self";
            string tittle = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, tittle, buttons,MessageBoxIcon.Information);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = " ";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult dr = MessageBox.Show("Do you want to save the file", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Declare open as a new OpenFileDailog
            OpenFileDialog open = new OpenFileDialog();
            //Set the Filename of the OpenFileDailog to nothing
            open.FileName = "";
            //Declare filename as a String equal to the OpenFileDialog's FileName
            String filename = open.FileName;
            //Declare filter as a String equal to our wanted OpenFileDialog Filter
            String filter = "Text Files|*.txt|All Files|*.*";
            //Set the OpenFileDialog's Filter to filter
            open.Filter = filter;
            //Set the title of the OpenFileDialog to Open
            open.Title = "Open";
            //Show the OpenFileDialog
            if (open.ShowDialog(this) == DialogResult.OK)
            {

                sfd.Filter = filter;

                sfd.Title = "Save";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {

                    //Write all of the text in txtBox to the specified file


                    System.IO.File.WriteAllText(filename, richTextBox1.Text);



                }

                else
                {

                    //Return

                    return;

                }
            }
            else
            {
                //Return
                return;
            }
        }


    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); sfd.Title = "Save";
            sfd.Filter = "TXT Files|*.txt"; 
            sfd.DefaultExt =".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName); 
                this.Text = sfd.FileName;
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sw = new SaveFileDialog();

            //Declare filename as a String equal to the SaveFileDialog's FileName

            string filename = sw.FileName;

            //Declare filter as a String equal to our wanted SaveFileDialog Filter

            String filter = "Text Files|*.txt|All Files|*.*";

            //Set the SaveFileDialog's Filter to filter

            sw.Filter = filter;

            //Set the title of the SaveFileDialog to Save

            sw.Title = "Save";

            //Show the SaveFileDialog

            if (sw.ShowDialog(this) == DialogResult.OK)
            {

                //Write all of the text in txtBox to the specified file



                System.IO.File.WriteAllText(filename, richTextBox1.Text);


            }

            else
            {

                //Return

                return;

            }
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

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

