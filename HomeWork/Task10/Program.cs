﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает вторую цифру этого числа. Решить без использования строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = new Random().Next(100, 1000);
int sot = number / 100;
int result = (number - sot * 100)  / 10;
Console.WriteLine($"Вторая цифра числа {number} -> {result}");