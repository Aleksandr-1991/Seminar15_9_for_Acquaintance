// №67. Прога принимает на вход число и возвращает сумму его цифр.
// 1 вар (со счётчиком действий): 
/*
void SumOfDigits(int number, int sum, int i) {
    if (number != 0) {
        sum += number % 10;
        number /= 10;
        i++;
        System.Console.WriteLine($"На шаге {i} сумма равна: {sum}");
        SumOfDigits(number, sum, i);
    }
}
int Promt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int number = Promt("Введите целое число: ");
int sum = 0;
int i = 0;
SumOfDigits(number, sum, i);      //*/

// 2 вар: /*

int SumOfDigits(int number, int sum){
    if (number != 0)
    {
        sum += number % 10;
        return SumOfDigits(number/10, sum);

        // этот же код в виде тернарного оператора:
        // return number !=0 ? SumOfDigits (number/10, sum + number%10) : sum;
    }
    return sum;
}

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

int number = GetNumber("Введите целое число: ");
int sum = 0;
Console.Write($"Сумма цифр в числе равна: {SumOfDigits(number, sum)}");      //*/