
namespace WindowsFormsApplication1
{
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
}
