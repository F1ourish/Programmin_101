// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

int [,] TranspolateMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
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

const int Rows = 3;
const int Columns = 4;
const int LeftBorder = 0;
const int RightBorder = 10;

int [,] myMatrix = GetMatrix(Rows, Columns, LeftBorder, RightBorder);
Console.WriteLine("Исходная матрица:");
PrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine("Полученная матрица:");
PrintMatrix(TranspolateMatrix(myMatrix));
