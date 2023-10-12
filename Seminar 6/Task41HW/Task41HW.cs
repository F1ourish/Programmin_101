// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumberCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] FillArray(int arrayLength)

{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

string PrintArrayAsString(string message, int[] array)
{
    string arrayString = string.Join(", ", array);
    Console.WriteLine($"{message} {arrayString}");
    return arrayString;
}

Console.Write("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = FillArray(arrayLength);

PrintArrayAsString("Введённый массив: ", myArray);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел в введённом массиве равно {PositiveNumberCounter(myArray)}.");
