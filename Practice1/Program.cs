Console.WriteLine("Классический калькулятор. Допустимые операции: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR");
Console.WriteLine("Для прекращения работы введите stop\n");

double cur = 0; ;
double memory = 0;
double number = 0;

while (true)
{
    Console.WriteLine($"Текущее значение: {cur}");
    Console.WriteLine("Введите число или операцию");
    string input = Console.ReadLine();
    if (input == "stop")
        break;
    else if (double.TryParse(input, out double x))
        cur = x;
    else
    {
        switch (input)
        {
            case "+":
                Console.WriteLine("Введите число");
                number = Convert.ToDouble(Console.ReadLine());
                cur = cur + number;
                break;
            case "-":
                Console.WriteLine("Введите число");
                number = Convert.ToDouble(Console.ReadLine());
                cur = cur - number;
                break;
            case "*":
                Console.WriteLine("Введите число");
                number = Convert.ToDouble(Console.ReadLine());
                cur = cur * number;
                break;
            case "/":
                Console.WriteLine("Введите число");
                number = Convert.ToDouble(Console.ReadLine());
                if (number == 0)
                    Console.WriteLine("ОШИБКА: деление на ноль");
                else
                    cur = cur / number;
                break;
            case "%":
                Console.WriteLine("Введите число");
                number = Convert.ToDouble(Console.ReadLine());
                cur = cur % number;
                break;
            case "1/x":
                if (cur == 0)
                    Console.WriteLine("ОШИБКА: деление на ноль");
                else
                    cur = 1 / cur;
                break;
            case "x^2":
                cur = cur * cur;
                break;
            case "sqrt":
                if (cur < 0)
                    Console.WriteLine("ОШИБКА: квадратный корень из отрицательного числа");
                else
                    cur = Math.Sqrt(cur);
                break;
            case "M+":
                memory += cur;
                Console.WriteLine($"Значение в памяти: {memory}");
                break;
            case "M-":
                memory -= cur;
                Console.WriteLine($"Значение в памяти: {memory}");
                break;
            case "MR":
                cur = memory;
                Console.WriteLine($"Значение в памяти: {memory}");
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }
    }
}


