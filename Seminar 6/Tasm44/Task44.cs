// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FibonacciNumbers(int size)
{
    int[] fibonacciArray = new int[size];
    fibonacciArray[0] = 0;
    fibonacciArray[1] = 1;
    for (int i = 2; i < size; i++)
    {
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
    }
    return fibonacciArray;
}

Console.WriteLine("Введите количество чисел последовательности Фибоначчи для вывода:");
int fibonacciArrayLength = int.Parse(Console.ReadLine()!);
int[] myArray = FibonacciNumbers(fibonacciArrayLength);
Console.WriteLine(string.Join(" ", myArray));
