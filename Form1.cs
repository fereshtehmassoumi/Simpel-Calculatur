namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calculator = new Calculator();
        double num1, num2;
        string operation;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "+";


        }
        public void clean()
        {


        }
        public class Calculator()
        {
            public double Add(double x, double y)
            { return x + y; }

            public double Mines(double x, double y)
            { return x - y; }
            public double Multipel(double x, double y)
            { return x * y; }
            public double Devid(double x, double y)
            { return x / y; }
        }

        private void btnmeines_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
             operation = "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
             operation = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
             operation = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            double result=0;
            switch (operation)
            {
                case "+":
                    result=calculator.Add(num1,num2);
                    break;
                case "-":
                    result = calculator.Mines(num1,num2);
                    break;
                    case "*":
                    result = calculator.Multipel(num1,num2);
                    break;
                    case "/":
                    result = calculator.Devid(num1,num2);
                    break;

                    

                        
            }
            textBox1.Text= Convert.ToString(result);
        }
    }
}
