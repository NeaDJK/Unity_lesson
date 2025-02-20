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
                Console.WriteLine();

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
                                Console.WriteLine($"Вывод: {firstNumber + secondNumber} \n");
                                break;

                            case '-':
                                Console.WriteLine($"Вывод: {firstNumber - secondNumber} \n");
                                break;

                            case '*':
                                Console.WriteLine($"Вывод: {firstNumber * secondNumber} \n");
                                break;

                            case '/':
                                if (secondNumber > 0)
                                {
                                    Console.WriteLine($"Вывод: {firstNumber / secondNumber} \n");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("На ноль делить нельзя! \n");
                                    break;
                                }

                            case '%':
                                if (secondNumber > 0)
                                {
                                    Console.WriteLine($"Вывод: {firstNumber % secondNumber} \n");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("На ноль делить нельзя! \n");
                                    break;
                                }

                            default:
                                Console.WriteLine("Введен некорректный оператор! \n");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("До свидания!");
                        break;

                    default:
                        Console.WriteLine("Введена некорректная команда! \n");
                        break;
                }
            }

            while (choise != 2);
        }
    }
}
