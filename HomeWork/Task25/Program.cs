// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите два числа.\n A: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numTwo = Convert.ToInt32(Console.ReadLine());
if (numTwo <= 0) Console.Write("Число не верно!");
else 
{
    int i = 1;
    int result = 1;
    while (i <= numTwo)
    {
        result *= numOne;
        i++;
    }
    Console.WriteLine($"{numOne}, {numTwo} -> {result}");
}