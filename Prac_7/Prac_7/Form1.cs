namespace Prac_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.listBox1.Items.Add(textBox1.Text);
                this.textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                this.listBox2.Items.Add(textBox2.Text);
                this.textBox2.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                this.listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
            this.listBox1.ClearSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                this.listBox1.Items.Add(listBox2.SelectedItems[i]);
            }
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
            this.listBox2.ClearSelected();
        }
    }
}