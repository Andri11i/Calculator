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
            if (result.CalcResult == "0") result.CalcResult = "";
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

        private void ActionAlt(string currentact)
        {
            result.OldResult = Equals(action).ToString();
            action = currentact;
            label1.Text = result.OldResult + " " + action;
            result.CalcResult = "0";
            UpdtTB();
        }

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
                ActionAlt("+");
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
                ActionAlt("-");
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
                ActionAlt("*");
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
                ActionAlt("/");
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (action != "")
            {
                label1.Text += " " + result.CalcResult + " = ";
                double calcres = Equals(action);
                result.OldResult = calcres.ToString();
                textBox1.Text = calcres.ToString();
                result.CalcResult = calcres.ToString();
                action = "";
            }
        }
        private void btnDOT_Click(object sender, EventArgs e)
        {
            string dot = ".";
            if (!result.CalcResult.Contains(dot)) result.AddSymbol(dot);
            UpdtTB();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            result.CalcResult = "0";
            UpdtTB();
        }

        private void btnBACKSPACE_Click(object sender, EventArgs e)
        {
            if (result.CalcResult != "0" || result.CalcResult != "")
            {
                result.CalcResult = result.CalcResult.Remove(result.CalcResult.Length - 1);
                if (result.CalcResult == "") result.CalcResult = "0";
                UpdtTB();
            }
        }
    }
}
