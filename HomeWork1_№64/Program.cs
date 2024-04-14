// Задача 64. Программа выводит все натуральные числа в промежутке от заданного N до 1. Выполнено с помощью рекурсии.
double GetNumber(string message)
{
    Console.Write(message);
    bool isCorrect = false;
    double result = 0;
    while (!isCorrect)
        if (double.TryParse(Console.ReadLine()!, out result))
        {
            if (result > 0 && result % 1 == 0)  isCorrect = true;
            else Console.WriteLine("Введено число, но не натуральное. Повторите ввод.");
        }
        else Console.WriteLine("Введено не число. Повторите ввод.");
    return result;
}

void WriteLineOfNumbers(double n)
{
    if (n == 1)
    {
        Console.Write(n + ".");
        return;
    }
    Console.Write($"{n}, ");
    WriteLineOfNumbers(n - 1);
}

WriteLineOfNumbers(GetNumber("Введите натуральное число N: "));