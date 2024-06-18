namespace Task1
{
    internal class Program
    {

        public delegate int MathDelegate(int x);

        public static int FactorialCounter(int y)
        {
            int result = 1;
            if (y < 0)
            {
                Console.WriteLine("Значение не верно записано");
            }
            else if (y == 0)
            {
                return 1;
            }
            else
                for (int i = 1; i < y + 1; i++)
                {
                    result *= i;
                }
            return result;
        }
        static void Main(string[] args)
        {
            MathDelegate xSquare = (x) => x * x;
            MathDelegate xFactorial = (x) => FactorialCounter(x);
            MathDelegate xABS = (x) => Math.Abs(x);

            Console.WriteLine($"Квадрат числа: {xSquare(-3)}");
            Console.WriteLine($"Факториал: {xFactorial(-3)}");
            Console.WriteLine($"Модуль: {xABS(3)}");
        }
    }
}