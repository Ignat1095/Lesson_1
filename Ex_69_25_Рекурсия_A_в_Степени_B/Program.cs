﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень: ");
int sf = int.Parse(Console.ReadLine()!);

int RecursionNumbers(int num, int sf)

{
    if (sf == 0) return 1;

    else return num * RecursionNumbers(num, sf - 1);
}
Console.Write("Ответ: ");
Console.WriteLine(RecursionNumbers(num, sf));









// int power_A(int A, int B)
// {
//     // int result = 1;

//     // for (int i = 1; i <= B; i++)
//     // {
//     //     result = result * A;

//     // }

//     int result = Convert.ToInt32(Math.Pow(A, B));
//     //int result = int.Parse(Math.Pow(A, B)); // не сработает!

//     return result;
// }

// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("В какую степень будем возводить? - ");
// int B = int.Parse(Console.ReadLine()!);

// int Power_A = power_A(A, B);

// Console.WriteLine("Ответ: " + Power_A);

