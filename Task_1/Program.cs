// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

using System;

class Program {
    static void Main(string[] args) {
        int count = 0; // счетчик чисел больше 0
        Console.Write("Введите количество чисел: ");
        int M = int.Parse(Console.ReadLine());

        for (int i = 0; i < M; i++) {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) {
                count++;
            }
        }

        Console.WriteLine("Количество чисел больше 0: " + count);
    }
}



