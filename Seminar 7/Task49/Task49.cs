// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] GetMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }    
}

int[,] NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // или так for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return matrix;
}

const int Rows = 6;
const int Columns = 6;
const int LeftBorder = -5;
const int RightBorder = 10;

int[,] myMatrix = GetMatrix(Rows, Columns, LeftBorder, RightBorder);
Console.WriteLine("Заданная матрица:");
PrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine("Новая матрица:");
int[,] newMatrix = NewMatrix(myMatrix);
PrintMatrix(newMatrix);
