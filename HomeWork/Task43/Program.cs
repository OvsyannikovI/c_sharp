﻿// Задача 43: Напишите программу, 
// которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; //  x = (b2 - b1)/(k1 - k2); y = k1 * ((b2 - b1)/(k1 - k2)) + b1;
// значения b1, k1, b2 и k2 задаются //
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффиценты b1, k1, b2 и k2 для уравнений y = k1 * x + b1, y = k2 * x + b2;");
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine("Точки пересечения нет");
else
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * ((b2 - b1)/(k1 - k2)) + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x:#.#}; {y:#.#})");
}