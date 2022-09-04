// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт 
//  сумму натуральных элементов в промежутке 
//  от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое положительное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int NaturalNumberSum(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num2 + NaturalNumberSum(num1, num2-1);
    // if (num1 > num2) return num1 += NaturalNumberSum(num1, num2++);
}

Console.Write(NaturalNumberSum(number1, number2));