namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Display name when click the button
         */
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Display Udara Text";
        }

        /**
         * Comment Modified by Udara
         */
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Display Suyang Text";
        }
    }
}
