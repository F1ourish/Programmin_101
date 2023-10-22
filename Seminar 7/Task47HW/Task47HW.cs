// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double a = Random.Shared.NextDouble(); задаёт от 0 до 1
// double a = Random.Shared.NextDouble() * 10; от 0 до 10
// double a = Random.Shared.NextDouble() * 10 - 5; от -5 до 5
// double minValue = -10;
// double maxValue = 10;

// double a = Random.Shared.NextDouble() * (maxValue - minValue) + minValue; // от -10 до 10
// Console.WriteLine(a);


// double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
//       // Введите свое решение ниже
//     double[,] matrix = new double[m, n];
//     Random random = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round((random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom), 1);
//         }
//     }
//     return matrix;
//   }

// void PrintArray(double[, ] matrix) {
//       // Введите свое решение ниже
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }  
//   }

//   // Не удаляйте и не меняйте метод Main! 
// void Main(string[] args) {
//     int m, n, minLimitRandom, maxLimitRandom;

//     if (args.Length >= 4) {
//       m = int.Parse(args[0]);
//       n = int.Parse(args[1]);
//       minLimitRandom = int.Parse(args[2]);
//       maxLimitRandom = int.Parse(args[3]);

//       double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

//         // Выберем случайные индексы трех элементов матрицы array
//         int row1 = new Random().Next(0, m);
//         int col1 = new Random().Next(0, n);
//         int row2 = new Random().Next(0, m);
//         int col2 = new Random().Next(0, n);
//         int row3 = new Random().Next(0, m);
//         int col3 = new Random().Next(0, n);

//         // Проверяем, являются ли выбранные элементы дробными числами
//         bool isFractional1 = (array[row1, col1] % 1) != 0;
//         bool isFractional2 = (array[row2, col2] % 1) != 0;
//         bool isFractional3 = (array[row3, col3] % 1) != 0;

//         // Если два из трех элементов не являются дробными числами, то бросаем исключение
//         if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
//         {
//             Console.WriteLine("Все ок!");
//         }
//         else
//         {
//             throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
//         }
//     } else {
//       m = 3;
//       n = 4;
//       minLimitRandom = -10;
//       maxLimitRandom = 10;
      
//       double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//       PrintArray(result);
//     }
//   }


void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    }

int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
    int[,] matrix = new int[n, m];
    int currentNum = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = currentNum;
            currentNum += k;
        }
    }
    return matrix;
}

double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
        double[] columnAvg = new double[matrix.GetLength(1)];
          
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        double elSum = 0.00;
          for (int i = 0; i < matrix.GetLength(0); i++)
          {
            {
            elSum += matrix[i, j];
            }
          }
        columnAvg[j] = Math.Round((elSum / matrix.GetLength(0)), 2);
        }
        return columnAvg;
    }

void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
    string arrayString = string.Join("\t", list);
    Console.WriteLine($"The averages in columns are:\n{arrayString}");
    }

int n = 3;
int m = 4;
int k = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
