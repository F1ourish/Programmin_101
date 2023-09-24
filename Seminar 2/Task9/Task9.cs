// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

using System.Globalization;

int num = Random.Shared.Next(10, 100);
Console.WriteLine(num);
int lastDigit = num % 10;
int firstDigit = num / 10;

if (lastDigit < firstDigit) Console.WriteLine($"Первая цифра больше второй и равна {firstDigit}.");
else if(lastDigit > firstDigit) Console.WriteLine($"Вторая цифра больше первой и равна {lastDigit}.");
else Console.WriteLine("Цифры равны.");
