namespace Calculator
{
    public partial class Form1 : Form
    {
        public Result result = null;


        public Form1()
        {
            InitializeComponent();

            result = new Result();
            textBox1.Text = result.CalcResult;

        }

        private double Equals(string action)
        {

            double calcres = 0;
            switch (action)
            {
                case "+":
                    calcres = result.Addition(Convert.ToDouble(result.OldResult), Convert.ToDouble(result.CalcResult));
                    break;
                case "-":
                    calcres = result.Subtraction(Convert.ToDouble(result.OldResult), Convert.ToDouble(result.CalcResult));
                    break;
                case "/":
                    calcres = result.Division(Convert.ToDouble(result.OldResult), Convert.ToDouble(result.CalcResult));
                    break;
                case "*":
                    calcres = result.Multiplication(Convert.ToDouble(result.OldResult), Convert.ToDouble(result.CalcResult));
                    break;
            }

            return calcres;
        }
        private void UpdtTB()
        {
            textBox1.Text = result.CalcResult;
        }
        private void numberclick(object sender, EventArgs e)
        {
            //textBox1.Text += ((Button)sender).Text;
            result.AddSymbol(((Button)sender).Text);
            UpdtTB();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            result = new Result();
            UpdtTB();
            label1.Text = "";
            action = "";
        }

        string action = "";
        private void btnPLUS_Click(object sender, EventArgs e)
        {
            if (action == "")
            {
                result.SaveCR();
                result.CalcResult = "0";
                UpdtTB();
                action = "+";
                label1.Text = result.OldResult + " +";
            }
            else
            {
                result.OldResult = Equals(action).ToString();
                action = "+";
                label1.Text = result.OldResult + " " + action;
                result.CalcResult = "0";
                UpdtTB();
            }
        }

        private void btnMINUS_Click(object sender, EventArgs e)
        {
            if (action == "")
            {
                result.SaveCR();
                result.CalcResult = "0";
                UpdtTB();
                action = "-";
                label1.Text = result.OldResult + " -";
            }
            else
            {
                
                result.OldResult = Equals(action).ToString();
                action = "-";
                label1.Text = result.OldResult + " " + action;
                result.CalcResult = "0";
                UpdtTB();
            }
        }


        private void btnMULT_Click(object sender, EventArgs e)
        {
            if (action == "")
            {
                result.SaveCR();
                result.CalcResult = "0";
                UpdtTB();
                action = "*";
                label1.Text = result.OldResult + " *";
            }
            else
            {
           
                result.OldResult = Equals(action).ToString();
                action = "*";
                label1.Text = result.OldResult + " " + action;
                result.CalcResult = "0";
                UpdtTB();
            }
        }

        

        private void btnDIVISION_Click(object sender, EventArgs e)
        {
            if (action == "")
            {
                result.SaveCR();
                result.CalcResult = "0";
                UpdtTB();
                action = "/";
                label1.Text = result.OldResult + " /";
            }
            else
            {
               
                result.OldResult = Equals(action).ToString();
                action = "/";
                label1.Text = result.OldResult + " " + action;
                result.CalcResult = "0";
                UpdtTB();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            label1.Text += " " + result.CalcResult + " = ";
            double calcres = Equals(action);
            result.OldResult = calcres.ToString();
            textBox1.Text = calcres.ToString();
            result.CalcResult = "0";
            
          
        }
    }
}
