// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}


int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);

int[] FillNewArray(int[] array)
{
    int[] newArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        // if (myArray.Length % 2 > 0) newArray[myArray.Length / 2] = myArray[myArray.Length / 2];
        if (i == myArray.Length - 1 - i) newArray[i] = myArray[i];
        else newArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
    }

    return newArray;
}

string PrintArrayAsString(string message, int[] array)
{
    string arrayString = string.Join(", ", array);
    Console.WriteLine($"{message} {arrayString}");
    return arrayString;
}

const int Length = 11;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] newArray = FillNewArray(myArray);
PrintArrayAsString("Сгенерированный массив:", myArray);
PrintArrayAsString("Новый массив:", newArray);
