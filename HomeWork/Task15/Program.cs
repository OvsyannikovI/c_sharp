// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели чтобы узнать выходной этот день или нет");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 ^ number > 7)
    Console.WriteLine("Число не верно!"); 
else if (number > 5 & number < 8) Console.WriteLine("да"); 
    else if (number > 0 & number < 6) Console.WriteLine("нет"); 
    