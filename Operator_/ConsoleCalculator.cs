namespace Operator_
{
    internal class ConsoleCalculator
    {
        static void Main(string[] args)
        {
            int choise = 0; //Значение выбора команды

            do 
            {
                //Начальное меню. Запрос ввода команды от пользователя
                Console.Write("[1] - Калькулятор\n[2] - Выход\nВведите номер команды: ");
                Int32.TryParse(Console.ReadLine(), out choise);
                Console.WriteLine();

                //Обработка команд
                switch (choise)
                {
                    case 1: //Режим калькулятора. Запрос чисел и оператора от пользователя
                        Console.Write("Введите первое число: ");
                        double.TryParse(Console.ReadLine(), out double firstNumber);

                        Console.Write("Введите второе число: ");
                        double.TryParse(Console.ReadLine(), out double secondNumber);

                        Console.Write("Введите оператор (+, -, *, /, %): ");
                        char.TryParse(Console.ReadLine(), out char operation);

                        //Обработка выбранной операции пользователем
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
                                //Проверка деления на ноль
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
                                //Проверка деления на ноль
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

                            //Обработка некорректного ввода оператора 
                            default:
                                Console.WriteLine("Введен некорректный оператор! \n");
                                break;
                        }
                        break;

                    //Выход из программы
                    case 2:
                        Console.WriteLine("До свидания!");
                        break;
                        
                    //Обработка некорректного ввода команды
                    default:
                        Console.WriteLine("Введена некорректная команда! \n");
                        break;
                }
            }

            while (choise != 2);
        }
    }
}
