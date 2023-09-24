// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(num) < 100) Console.WriteLine("У числа нет третьей цифры.");
else
{
    while (Math.Abs(num) > 999) num = num / 10;
    Console.WriteLine($"Третья цифра заданного числа: {Math.Abs(num) % 10}.");
}
