namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberclick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            textBox1.Text += buttonText;
        }

      
    }
}
