// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = Random.Shared.Next(100, 1000);
Console.WriteLine($"Сгенерировано число {num}.");
int firstDigit = num / 100;
int secDigit = num % 10;
int result = firstDigit * 10 + secDigit;
Console.WriteLine($"Полученное число: {result}.");
