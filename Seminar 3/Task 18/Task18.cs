// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

public static void Main(string[] args)
{
    int number = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
        case 1:
            Console.WriteLine("x(>0) y(<0)");
            break;
        case 2:
            Console.WriteLine("x(<0) y(>0)");
            break;
        case 3:
            Console.WriteLine("x(<0) y(<0)");
            break;
        case 4:
            Console.WriteLine("x(>0) y(<0)");
            break;
        default:
            Console.WriteLine("Некорректное значение.");
            break;
    }
}

// Альтернативный вариант использования switch

// Console.WriteLine("Введите номер координатной четверти");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number switch
// {
// 1 => "x > 0, y > 0",
// 2 => "x < 0, y > 0",
// 3 => "x < 0, y < 0",
// 4 => "x > 0, y < 0",
// _ => "Ошибка"
// });