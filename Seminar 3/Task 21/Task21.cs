// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = sqrt((xb - xa)**2 + (yb - ya)**2)

int InputAndCheck(string message)
{
    bool check = false;
    int output = 0;
    while(check != true)
    {
        System.Console.WriteLine(message);
        string input = Console.ReadLine();
        check = int.TryParse(input, out output);
        if(check == false)
        {
            System.Console.WriteLine("Неверные данные.");
        }
    }
    return output;
}

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

void Distance(int x1, int y1, int x2, int y2)
{
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2));
}

Console.Clear();
int x1 = InputAndCheck("Введите x1:");
int y1 = InputAndCheck("Введите y1:");
int x2 = InputAndCheck("Введите x2:");
int y2 = InputAndCheck("Введите y2:");
Distance(x1, y1, x2, y2);
