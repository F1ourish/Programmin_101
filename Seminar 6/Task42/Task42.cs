// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Convert(int number)
{
    int arrSize = 0;
    int i = 0;
    for (i = 0; number > 0; i++)
    {
        // temp = number % 2;
        number = number / 2;
        arrSize++;
    }
    return arrSize;
}

int[] FillReversedArray(int size, int number)
{
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[myArray.Length - i - 1] = number % 2;
        number = number / 2;
    }
    return myArray;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int arraySize = Convert(num);
Console.WriteLine(string.Join("", FillReversedArray(arraySize, num)));

// Решение через рекурсию

// int number = 13;

// void PrintBinaryView(int number)
// {
//     if (number <= 0) return;
//     PrintBinaryView(number / 2);
//     Console.Write(number % 2);
// }

// PrintBinaryView(number);
