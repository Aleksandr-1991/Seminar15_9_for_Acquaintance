// №69: Прога принимает два числа A и B, и возводит А в целую степень B с помощью рекурсии.

int Multiply(int a, int b)
{
    if (b ==0) return 1;
    return a * Multiply(a, b - 1);
}
int Promt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int a = Promt("Введите значение a: ");
int b = Promt("Введите значение b: ");

Console.Write($"Число {a} в степени {b} равно: {Multiply(a, b)}.");