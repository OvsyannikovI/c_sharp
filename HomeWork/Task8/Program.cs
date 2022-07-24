// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число больше 1");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb <= 1 ) 
{
    Console.WriteLine("Число должно быть больше 1");
}
else 
{
    int count = 1;
    Console.WriteLine($"Четные числа от 1 до {numb}:");
    while (count < numb)
    {
        if (count%2 == 0) Console.Write($" {count}; ");
        count++;
    }
}