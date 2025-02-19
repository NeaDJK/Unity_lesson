namespace Operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;

            do 
            {
                Console.Write("[1] - Калькулятор\n[2] - Выход\nВведите номер команды: ");
                Int32.TryParse(Console.ReadLine(), out choise);

                switch (choise)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        double.TryParse(Console.ReadLine(), out double firstNumber);

                        Console.Write("Введите второе число: ");
                        double.TryParse(Console.ReadLine(), out double secondNumber);

                        Console.Write("Введите оператор (+, -, *, /, %): ");
                        char.TryParse(Console.ReadLine(), out char operation);

                        switch (operation)
                        {
                            case '+':
                                Console.WriteLine($"Вывод: {firstNumber + secondNumber}");
                                break;

                            case '-':
                                Console.WriteLine($"Вывод: {firstNumber - secondNumber}");
                                break;

                            case '*':
                                Console.WriteLine($"Вывод: {firstNumber * secondNumber}");
                                break;

                            case '/':
                                Console.WriteLine($"Вывод: {firstNumber / secondNumber}");
                                break;

                            case '%':
                                Console.WriteLine($"Вывод: {firstNumber % secondNumber}");
                                break;

                            default:
                                Console.WriteLine("Введен некорректный оператор!");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("До свидания!");
                        break;

                    default:
                        Console.WriteLine("Введена некорректная команда!");
                        break;
                }
            }

            while (choise != 2);
        }
    }
}
