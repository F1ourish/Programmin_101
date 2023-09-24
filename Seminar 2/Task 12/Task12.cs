// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 % num1 == 0) System.Console.WriteLine("Число 2 кратно числу 1.");
else System.Console.WriteLine($"Число 2 не краткно числу 1, остаток от деления {num2 % num1}.");
