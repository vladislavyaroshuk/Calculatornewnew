using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string action;
        public string number1;
        public bool flag;
        public Form1()
        {
            flag = false;
            InitializeComponent();
        }

        private void Input(object sender, EventArgs e)
        {
            try
            {
                if(flag)
                {
                    flag = false;
                    textBox1.Text = "";
                }
                Button button = (Button)sender;
                textBox1.Text += button.Text;
            }
            catch
            {
                MessageBox.Show("Error");
                textBox1.Text = "";
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
            number1 = textBox1.Text;
            flag = true;
        }

        private void Equal(object sender, EventArgs e)
        {
            try
            {
                int operand1 = int.Parse(number1);
                int operand2 = int.Parse(textBox1.Text);
                int result = 0;
                switch (action)
                {
                    case "+":
                        result = Calculator.Sum(operand1, operand2);
                        break;
                    case "-":
                        result = Calculator.Minus(operand1, operand2);
                        break;
                    case "*":
                        result = Calculator.Multiple(operand1, operand2);
                        break;
                    case "/":
                        result = Calculator.Devide(operand1, operand2);
                        break;
                    default:
                        MessageBox.Show("Something in the way");
                        break;
                }
                textBox1.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Swap(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox1.Text = (int.Parse(textBox1.Text)*(-1)).ToString();
            }
            else
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
