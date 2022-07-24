// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int a1 = 5, b1 = 7,
    a2 = 2, b2 = 10,
    a3 = -9, b3 = -3;

int Max (int a, int b)
{
    int max = a;
    if (b > max) max = b;
    return max;
}

int max1 = Max(a1,b1);
int max2 = Max(a2,b2);
int max3 = Max(a3,b3);

Console.WriteLine($"Максимальное число из {a1} и {b1} это {max1}");
Console.WriteLine($"Максимальное число из {a2} и {b2} это {max2}");
Console.WriteLine($"Максимальное число из {a3} и {b3} это {max3}");