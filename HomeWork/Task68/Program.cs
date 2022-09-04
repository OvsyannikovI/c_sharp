// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое целое положительное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else 
        if ((num1 != 0) && (num2 == 0)) return AkkermanFunction(num1 - 1, 1);
        else return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}

Console.WriteLine(AkkermanFunction(number1, number2));