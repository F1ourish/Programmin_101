// Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

int[,] FillArr(int n, int m)
{
    Random random = new Random();
    int[,] arr = new int[n, m];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
    return arr;
}

int[] FindMin(int[,] arr)
{
    int min = arr[0, 0];
    int[] minEl = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minEl[0] = i;
                minEl[1] = j;
            }
        }
    }
    Console.WriteLine(minEl[0]+ " " + minEl[1]);
    return minEl;
}

int[,] NewArr(int[,] arr)
{
    int rowOff = 0;
    int columnOff = 0;
    int[] minEl = FindMin(arr);
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        if (i == minEl[0])  rowOff++;

        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (j == minEl[1]) columnOff++;
            newArr[i, j] = arr[i + rowOff, j + columnOff];
        }
        columnOff = 0;
    }

    return newArr;
}

int[,] arr = FillArr(5, 5);
Console.WriteLine("Первый массив");
PrintArray(arr);

Console.WriteLine("Новый массив");
int[,] newArr = NewArr(arr);
PrintArray(newArr);
