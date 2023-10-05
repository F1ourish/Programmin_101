// Решение в группах задач:
// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int GetInt(string message)
{
    int result;
    Console.WriteLine(message);
    while(!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine("Ошибка ввода. Введите число.");
    }
    return result;
}


int num = GetInt("Введите число:");

Console.Clear();
for(int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}
