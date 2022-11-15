/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Вариант 1

Console.WriteLine("Введите натуральное числое N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NaturFigures(N));

string NaturFigures (int n)
{
    if (n == 1) return n.ToString();
    return (n + " " + NaturFigures(n - 1));
}

Вариант 2

Console.WriteLine("Введите натуральное числое N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NaturFigures(N));

string NaturFigures (int n)
{
    if (n >= 1) return $"{n} " + NaturFigures(n - 1);
    else return String.Empty;
}
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Введите натуральное числое M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное числое N, большее М: ");
int N = int.Parse(Console.ReadLine()!);
if (N > M) Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {Sum(M, N)}");
else Console.WriteLine("Число N введено некорректно!");

int Sum (int a, int b)
{
    if (a == b) return a;
    else return a + Sum(a + 1, b);
}
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
A(m,n)=n+1, если m=0
A(m,n)=A(m-1,1), если m>0, n=0
A(m,n)=A(m-1,A(m,n-1)), если m>0, n>0

Вариант 1
Алгоритм перестает работать (stack overflow) уже для: 2\16206, 3\12, 4\1, 5\0

Console.Write("Введите натуральное числое m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное числое n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана равна {Ackermann(m, n)} для m = {m} и n = {n}");

int Ackermann (int a, int b)
{
    if (a == 0) return b + 1;
    else
    {
        if (a > 0 && b == 0) return Ackermann(a - 1, 1);
        else return Ackermann(a - 1, Ackermann(a, b - 1));
    }
}

Вариант 2
Алгоритм перестает работать, начина с 3\28, 4\2 и 5\1

Console.Write("Введите натуральное числое m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное числое n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана равна {Ackermann(m, n)} для m = {m} и n = {n}");

int Ackermann (int a, int b)
{
    switch (a)
    {
        case 0:
            return b + 1;
        case 1:
            return b + 2;
        case 2:
            return 2 * b + 3;
        case 3:
            return Convert.ToInt32(Math.Pow(2, b + 3)) - 3;
        default:
            if (a > 3 && b == 0) return Ackermann(a - 1, 1);
            else return Ackermann(a - 1, Ackermann(a, b - 1));
    }
}
*/