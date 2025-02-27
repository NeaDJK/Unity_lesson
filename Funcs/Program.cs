namespace Funcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum;
            int maxNum;
            int step;
            int choise;

            do
            {
                Console.Write("[1] - Режим калькулятора\n[2] - Создать список с заданным шагом\n[0] - Выход\nВведите номер команды: ");
                int.TryParse(Console.ReadLine(), out choise);
                Console.WriteLine();

                switch (choise)
                {
                    case 1: //Режим калькулятора. Запрос чисел и оператора от пользователя
                        Console.Write("Введите первое число: ");
                        double.TryParse(Console.ReadLine(), out double firstNumber);

                        Console.Write("Введите второе число: ");
                        double.TryParse(Console.ReadLine(), out double secondNumber);

                        Console.Write("Введите оператор (+, -, *, /, %): ");
                        char.TryParse(Console.ReadLine(), out char operation);

                        switch (Calculator(firstNumber, secondNumber, operation))
                        {
                            case 0:
                                Console.WriteLine("\nВведен некорректный оператор!\n");
                                break;

                            case -2:
                                Console.WriteLine("\nНа ноль делить нельзя!\n");
                                break;

                            default:
                                Console.WriteLine($"Вывод: {Calculator(firstNumber, secondNumber, operation)}");
                                break;
                        }
                        break;

                    case 2:
                        Console.Write("Введите минимальное число списка: ");
                        int.TryParse(Console.ReadLine(), out minNum);

                        do
                        {
                            Console.Write("Введите максимальное число списка: ");
                            int.TryParse(Console.ReadLine(), out maxNum);

                            if (maxNum <= minNum)
                            {
                                Console.WriteLine("Максимальное число должно быть больше минимального! Повторите попытку.");
                            }
                        } while (!(maxNum > minNum));

                        do
                        {
                            Console.Write("Введите шаг чисел: ");
                            int.TryParse(Console.ReadLine(), out step);

                            if (step >= (maxNum - minNum))
                            {
                                Console.WriteLine("Шаг чисел должен быть меньше, чем разница между максимальным и минимальным числом! Повторите попытку.");
                            }
                        } while (!(step < (maxNum - minNum)));

                        Console.Write("\nИтоговый список: ");
                        foreach (int number in FillArray(minNum, maxNum, step))
                        {
                            Console.Write($"{number} ");
                        }

                        Console.WriteLine("\n");
                        break;

                    case 0:
                        Console.WriteLine("До свидания!");
                        break;

                    default:
                        Console.WriteLine("Введена некорректная команда!\n");
                        break;
                }
            } while (choise != 0);
        }

        static double Calculator(double firstNumber, double secondNumber, char operation)
        {
            //Обработка выбранной операции пользователем
            switch (operation)
            {
                case '+':
                    return firstNumber + secondNumber;

                case '-':
                    return firstNumber - secondNumber;

                case '*':
                    return firstNumber * secondNumber;

                case '/':
                    //Проверка деления на ноль
                    if (secondNumber > 0)
                    {
                        return firstNumber / secondNumber;
                    }

                    else
                    {
                        return -2;
                    }

                case '%':
                    //Проверка деления на ноль
                    if (secondNumber > 0)
                    {
                        return firstNumber % secondNumber;
                    }

                    else
                    {
                        return -2;
                    }

                //Обработка некорректного ввода оператора 
                default:
                    return 0;       
            }
        }

        static List<int> FillArray(int min, int max, int step)
        {
            List<int> numbers = new();

            for (int i = min; i < (max + 1); i += step)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
