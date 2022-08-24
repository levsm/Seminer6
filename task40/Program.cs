﻿
// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число C");
int c = int.Parse(Console.ReadLine()!);

if(a < b + c && b< c + a && c < b + a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}