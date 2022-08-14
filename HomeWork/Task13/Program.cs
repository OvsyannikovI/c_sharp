// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 )
{
    Console.WriteLine($"Третья цифра числа {number} равна");
    while (number >1000)
    {
        number = number / 10;
    }
    int sot = number / 100;
    int dec = (number - sot * 100)  / 10;
    int three = (number - sot * 100 - dec * 10);
    Console.WriteLine($" {three}");
} else
{
    Console.WriteLine("Число не верно");
}
// int sot = number / 100;