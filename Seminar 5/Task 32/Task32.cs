// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }

    return array;
}

string PrintArrayAsString(int[] array)
{
    string arrayString = string.Join(", ", array);
    Console.WriteLine(arrayString);
    return arrayString;
}

const int Length = 12;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
PrintArrayAsString(myArray);
int[] reversedArray = ReverseArray(myArray);
PrintArrayAsString(reversedArray);
