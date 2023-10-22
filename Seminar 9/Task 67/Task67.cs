// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfNumbers(int n)
{
    if (n / 10 == 0) return n;
    else return n % 10 + SumOfNumbers(n / 10);
}

const int N = 45;
Console.WriteLine($"{SumOfNumbers(N)}");
