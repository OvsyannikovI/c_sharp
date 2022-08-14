// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int number = Convert.ToInt32(Console.ReadLine());
while (number) do


int sot = number / 100;
int dec = (number - sot * 100)  / 10;
int ed = (number - sot * 100 - dec * 10);
int result = sot * 10 + ed;
Console.WriteLine(number + " " + sot + " " + dec + " " + ed);
Console.WriteLine(result);