// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber()
{
    Console.WriteLine("Введите число:");
    return int.Parse(Console.ReadLine()!);
}

int DigitSum(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int number = ReadNumber();
if(number > 1)
{
    int result = DigitSum(number);
    Console.WriteLine($"Сумма цифр числа {number} равно {result}.");
}
else
{
    Console.WriteLine($"Ошибка ввода. Введите число больше 1.");
}

