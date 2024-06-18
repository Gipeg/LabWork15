namespace DelegateExample
{
    public delegate void MathOperation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathDelegate = new MathOperation(Sum); //сумма
            mathDelegate += Difference; //разность
            mathDelegate += Product; //произведение
            mathDelegate += Quotient; // частное

            int a = 10;
                int b = 5;

            mathDelegate(a, b);

            static void Sum(int x, int y)
            {
                Console.WriteLine($"Сумма: { x + y }");
            }
            static void Difference(int x, int y) 
            {
                Console.WriteLine($"Равность: { x - y}");
            }
            static void Product(int x, int y)
            {
                Console.WriteLine($"Произведение: {x * y}");
            }
            static void Quotient(int x, int y)
            {
                if (y != 0 )
                {
                    Console.WriteLine($"Частное: {x / y}");
                }
                else
                {
                    Console.WriteLine("Невозможно найти");
                }
            }

        }
    }
}