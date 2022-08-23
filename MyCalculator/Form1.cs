namespace MyCalculator
{
    public partial class FormCalculator : Form
    {
        Calculator calculator = new Calculator();

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "0";
            labelResult.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1";
            labelResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2";
            labelResult.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3";
            labelResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4";
            labelResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5";
            labelResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6";
            labelResult.Text += "6";
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7";
            labelResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8";
            labelResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9";
            labelResult.Text += "9";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxResult.Text);
            calculator.Operator = "+";
            labelResult.Text += " + ";
            textBoxResult.Clear();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxResult.Text);
            calculator.Operator = "-";
            labelResult.Text += " - ";
            textBoxResult.Clear();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxResult.Text);
            calculator.Operator = "*";
            labelResult.Text += " * ";
            textBoxResult.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxResult.Text);
            calculator.Operator = "/";
            labelResult.Text += " / ";
            textBoxResult.Clear();
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxResult.Text);
            calculator.Operator = "^";
            labelResult.Text += " ^ ";
            textBoxResult.Clear();
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxResult.Text);
            labelResult.Text = String.Format("The square root of {0} = {1}", textBoxResult.Text, calculator.CalculateSquareRoot());            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculator.Number2 = Convert.ToDouble(textBoxResult.Text);
            labelResult.Text += String.Format(" = {0}", calculator.Calculate());
            textBoxResult.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            labelResult.Text = "";
        }
    }
}