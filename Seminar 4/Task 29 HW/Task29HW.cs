// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse(ReadInput)!;
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальное значение для диапазона чисел: ");
int max = Prompt("Введите максимальное значение для диапазона чисел: ");
int[] array = GenerateArray(length, min, max);

PrintArray(array);
