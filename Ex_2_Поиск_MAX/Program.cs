﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3

//Перво число
int a, b;
a = 5;
b = 7;

if (a < b)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(a);
}

//Второе число
int a2, b2;
a2 = 2;
b2 = 10;

if (a2 < b2)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(b2);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(a2);
}

//третье Число
int a3, b3;
a3 = -9;
b3 = -3;

if (a3 < b3)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(b3);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(a3);
}
























//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

Console.Write("Введите значения числа А: ");
int Numb_A = int.Parse(Console.ReadLine()!);

Console.Write("Введите значения числа В: ");
int Numb_B = int.Parse(Console.ReadLine()!);

int max_Number;
if (Numb_A > Numb_B)
{
    max_Number = Numb_A;
    Console.WriteLine("Число А больше");
}

else Console.WriteLine("Число B больше");

if (Numb_A == Numb_B)
{
    Console.WriteLine("Числа равны друг другу ;D");
}




