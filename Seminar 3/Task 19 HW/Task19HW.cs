// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
        if(number < 100_000 && number > 9999)
        {
          if(number / 10_000 == number % 10)
          {
            number = number % 10_000;
            number = number / 10;
            if(number / 100 == number % 10) return true;
            else return false;
          }
          else return false;
        }
        else 
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) 
      {
        int number;

        if (args.Length >= 1) 
        {
            number = int.Parse(args[0]);
        } else 
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 14212;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}


// Эталонное решение:

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//         if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;
//     }

//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 645464;
//         }

//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }