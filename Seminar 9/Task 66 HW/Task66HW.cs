// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintNumberSequence(int m, int n)
{
    if (n <= m) return m;
    return n + PrintNumberSequence(m, n - 1);
}

const int M = 1;
const int N = 15;
Console.WriteLine($"{PrintNumberSequence(M, N)}");

