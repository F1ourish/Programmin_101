// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

int SumPositiveElementsAtArray(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int SumNegativeElementsAtArray(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

const int Length = 12;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
string myArrayString = string.Join(", ", myArray); //int[] -> string
Console.WriteLine(myArrayString);
int sumPositive = SumPositiveElementsAtArray(myArray);
int sumNegative = SumNegativeElementsAtArray(myArray);

Console.WriteLine($"Сумма положительных элементов массива = {sumPositive}, отрицательных = {sumNegative}.");
