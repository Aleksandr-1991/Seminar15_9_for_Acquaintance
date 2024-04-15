// №69: Прога принимает два числа A и B, и возводит А в целую степень B с помощью рекурсии.

int Exponentiation(int basis, int degree, int akk){  // Реализация хвостовой рекурсии.
    if (degree == 0) return akk;             // Для чего введена п-менная аккумулятор.
    return Exponentiation(basis, degree - 1, akk * basis);
}   // (ес домножать каждый вызов f-ции на множитель, это ведёт к переполнению стека).

int Promt(string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int basis  = Promt("Введите значение основы, возводимой в степень: ");
int degree = Promt("Введите значение степени: ");
int akk = 1;

Console.Write($"Число {basis} в степени {degree} равно: {Exponentiation(basis, degree, akk)}.");