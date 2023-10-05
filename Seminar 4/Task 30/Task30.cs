// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
    return array;
}

Console.WriteLine("Введите размер массива.");
int size = int.Parse(Console.ReadLine()!);
FillArray(size);


// Сложить 2 массива одинаковой длины.
// [1, 2, 3, 4] + [2, 4, 6, 6] = [3, 6, 9, 10]

// Console.WriteLine("Введите количество элементов массива:");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Random rand = new Random();
// int[] arr1 = new int[n];
// int[] arr2 = new int[n];
// int[] arr3 = new int[n];
// for (int i = 0; i < arr1.Length; i++)
// {
//     arr1[i] = rand.Next(0, 10);
//     arr2[i] = rand.Next(0, 10);
//     arr3[i] = arr1[i] + arr2[i];
// }

// for (int i = 0; i < arr1.Length; i++)
// {
//     Console.Write(arr1[i] + " ");
// }
// Console.WriteLine();
// for (int i = 0; i < arr2.Length; i++)
// {
//     Console.Write(arr2[i] + " ");
// }
// Console.WriteLine();
// for (int i = 0; i < arr3.Length; i++)
// {
//     Console.Write(arr3[i] + " ");
// }
