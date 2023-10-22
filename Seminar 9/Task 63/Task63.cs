// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintNumberSequence(int n)
{
    if (n == 1)
    {
        Console.Write(1);
    }
    else
    {
        PrintNumberSequence(n - 1);
        Console.Write($", {n}");
    }
}

const int Number = 8;
PrintNumberSequence(Number);
