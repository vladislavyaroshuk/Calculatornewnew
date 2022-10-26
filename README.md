# Calculator by Yaroshuk Vladislav, 20IT-2

**Калькулятор позволяет выполнять следующие операции**
- Сложение
- Вычитание
- Умножение
- Деление

## Классы

### Класс Calculator
Класс Calculator содержит 4 метода. Рассмотрим их код ниже
```
public static class Calculator
    {
        public static int Sum(int firstOperand, int secondOperand)
        {
            int result = firstOperand + secondOperand;
            return result;
        }
        public static int Minus(int firstOperand, int secondOperand)
        {
            int result = firstOperand - secondOperand;
            return result;
        }
        public static int Multiple(int firstOperand, int secondOperand)
        {
            int result = firstOperand * secondOperand;
            return result;
        }
        public static int Devide(int firstOperand, int secondOperand)
        {
            int result = firstOperand / secondOperand;
            return result;
        }
    }
```
### Класс Form1
Данный класс используется для графической интерпретации написанного кода. 
Класс содержит 5 методов. 
Представленный ниже метод Input позволяет вводить информацию в textBox.
```
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
```
Данный метод очищает textBox по нажатию на кнопку С.
```
private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
```
Представленный метод определяет действие, которое мы будем выполнять
```
private void Operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
            number1 = textBox1.Text;
            flag = true;
        }
```
Основной метод данного калькулятора, выполняющий все действия. Код находится ниже:
```
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
                        break;
                }
                textBox1.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
```
Метод, меняющий знак у числа, находящегося в textBox'e, по нажатию кнопки +/-
```
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
```

## UnitTest
В калькуляторе представлен еще один класс, именуемый UnitTest1. 
Данный класс тестирует методы, содержащиеся в классе Calculator.
Код данного класса содержится ниже:
```
public class UnitTest1
    {
        [TestMethod]
        [DataRow(4,6)]
        public void TestSum(int a, int b)
        {
            var expResult = a + b;

            var result = Calculator.Sum(a, b);

            Assert.AreEqual(expResult, result);
        }

        [TestMethod]
        [DataRow(7, 5)]
        public void TestMinus(int a, int b)
        {
            var expResult = a - b;

            var result = Calculator.Minus(a, b);

            Assert.AreEqual(expResult, result);
        }

        [TestMethod]
        [DataRow(6, 2)]
        public void TestMultiple(int a, int b)
        {
            var expResult = a * b;

            var result = Calculator.Multiple(a, b);

            Assert.AreEqual(expResult, result);
        }

        [TestMethod]
        [DataRow(10, 2)]
        public void TestDivide(int a, int b)
        {
            var expResult = a / b;

            var result = Calculator.Devide(a, b);

            Assert.AreEqual(expResult, result);
        }
    }
```
## Интерфейс калькулятора
Калькулятор содержит 17 кнопок и 1 textBox. Калькулятор содержит собственный логотип.
Также в данном приложении отключено свойство Maximized.
Интерфейс выглядит следующим образом:

![Интерфейс калькулятора](https://sun9-4.userapi.com/impg/d7xJ5iwOXrmZqcqtuQawdOVy0BHkXscD0hR3MA/KJ9fA7YYuAI.jpg?size=464x450&quality=96&sign=e613a6844f4ac98b009e29b8f9c822c0&type=album)
