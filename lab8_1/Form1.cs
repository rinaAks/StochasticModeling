namespace lab8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "") { label2.Text = "������������ ������"; }
            else
            {
                if (rnd.Next(0, 2) == 0) label2.Text = "���";
                else label2.Text = "��!";
            }
            label2.Visible = true;

        }
    }
}
