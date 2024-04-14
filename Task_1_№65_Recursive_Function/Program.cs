// №65. Задайте значения M и N. Прога выводит все натуральные числа в промежутке от M до N.
int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void Range (int m, int n) {
    Console.Write(m + " ");
    if (m==n) return;
    Range(m+1, n);
}

Range(Promt("Введите число M: "),  Promt("Введите число N: "));