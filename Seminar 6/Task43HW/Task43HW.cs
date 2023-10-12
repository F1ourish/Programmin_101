// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// для пересечения должна быть общая точка на осях x и y => k1*x + b1 = k2*x + b2; k1*x - k2*x = b2 - b1; x = (b2 - b1) / (k1 - k2); 
// y можно не выводить, просто подставить в программе значение первой формулы

double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}

bool LinesCheck(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают.");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны.");
            return false;
        }
    }
    return true;
}

Console.Write("Введите угловой коэффициент k для первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите угловой коэффициент k для второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку пересечения с осью Y для первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку пересечения с осью Y для второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (LinesCheck(k1, k2, b1, b2))
{
    Console.WriteLine($"Координаты пересечения заданных прямых x = {FindX(k1, b1, k2, b2)} и y = {FindY(FindX(k1, b1, k2, b2), k1, b1)}");
}
