// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int ReadNumber()
{
    Console.WriteLine("Введите число:");
    return int.Parse(Console.ReadLine()!);
}

int DigitCount(int num)
{
    int counter = 0;

    while (num > 0)
    {
        num = num / 10;
        counter += 1;
    }
    return counter;
}

int number = ReadNumber();
if(number > 1)
{
    int result = DigitCount(number);
    Console.WriteLine($"В числе {number} количество цифр равно {result}.");
}
else
{
    Console.WriteLine($"Ошибка ввода. Введите число больше 1.");
}
