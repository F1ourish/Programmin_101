// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координату по оси Ox:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Oy:");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в 1й координатной четверти.");
}
else if(x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в 2й координатной четверти.");
}
else if(x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в 3й координатной четверти.");
}
else if(x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в 4й координатной четверти.");
}
else
{
    System.Console.WriteLine("Невозможно определить координатную четверть.");
}
