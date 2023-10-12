// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

string PrintArrayAsString(string message, int[] array)
{
    string arrayString = string.Join(", ", array);
    Console.WriteLine($"{message} {arrayString}");
    return arrayString;
}

int ElementsCount(int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) Count += 1;
    }

    return Count;
}

const int Length = 123;
const int LeftBorder = 0;
const int RightBorder = 1000;

int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
PrintArrayAsString("Сгенерированный массив:", myArray);
Console.WriteLine($"В сгенерированном массиве {ElementsCount(myArray)} элементов в интервале [10, 99].");
