﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели числом:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7) Console.WriteLine("Указанный день является выходным.");
else Console.WriteLine("Указанный день НЕ является выходным.");