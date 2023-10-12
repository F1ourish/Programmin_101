// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}


bool FindInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

string PrintArrayAsString(int[] array)
{
    string arrayString = string.Join(", ", array);
    Console.WriteLine($"Сгенерированный массив: {arrayString}");
    return arrayString;
}

const int Length = 12;
const int LeftBorder = -9;
const int RightBorder = 9;
const int Number = 3;

int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
PrintArrayAsString(myArray);
System.Console.WriteLine($"Искомое число {Number}.");
bool result = FindInArray(myArray, Number);

if (result == true) Console.WriteLine("Искомое число есть в массиве.");
else Console.WriteLine("Искомого числа нет в массиве.");
