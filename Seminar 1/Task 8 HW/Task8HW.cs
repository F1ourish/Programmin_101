// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (num < i) Console.WriteLine("До введённого числа нет положительных чётных чисел.");
else
{
    while (i <= num)
    {
    Console.WriteLine(i);
    i = i + 2;
    }
}
