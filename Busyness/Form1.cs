namespace Busyness
{
    public partial class Form1 : Form
    {
        string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
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
                if (textBox1.Text == "Malay" && textBox2.Text == "2002")
                {
                    main m = new main(textBox1.Text);
                    m.Name = textBox1.Text;
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Data!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}