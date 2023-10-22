// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
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

void ElementsCounter(int [,] matrix)
{
    for (int temp = 0; temp < 10; temp++)
    {
        int counter = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                    if (temp == matrix[i, j]) counter++;
            }
        }
        Console.WriteLine($"Число {temp} встречается {counter} раз(а).");
    }
}

const int Rows = 3;
const int Columns = 4;
Console.WriteLine("Исходная матрица:");
int [,] myMatrix = GetMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
ElementsCounter(myMatrix);
