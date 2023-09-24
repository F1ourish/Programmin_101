// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите первое число: ");
string num1String = Console.ReadLine()!;

// int num1Int = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
string num2String = Console.ReadLine()!;
int num1Int = Convert.ToInt32(num1String);
int num2Int = Convert.ToInt32(num2String);
int sqr = num2Int * num2Int;
if(sqr == num1Int)
{
    Console.WriteLine("Является квадратом второго числа");
}
    else
    {
        Console.WriteLine("Не является квадратом второго числа");
    }