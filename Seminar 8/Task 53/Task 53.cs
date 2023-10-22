// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] FillMatrix(int n, int m)
{
    Random rand = new Random();
    int [,] matrix = new int[n, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 20);
        }
    }
    return matrix;
}

int [,] SwapFirstAndLastRows(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
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

int [,] myMatrix = FillMatrix(5, 3);
Console.WriteLine("Сгенерированная матрица:");
PrintMatrix(myMatrix);
Console.WriteLine();
int [,] swapedMatrix = SwapFirstAndLastRows(myMatrix);
Console.WriteLine("Полученная матрица:");
PrintMatrix(swapedMatrix);
