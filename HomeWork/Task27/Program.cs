// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите  число: ");
int x = Convert.ToInt32(Console.ReadLine());

int SizeNumber(int num)
{
    int i = 0;
    while (num >= 10)
    {
        num = num/10;
        i++;
    }
    i++;
    return i;
}
int number = x;
int[] arr = new int[SizeNumber(x)];
int i = 0;
int summ = 0;
while (i < arr.Length)
{
    arr[i] = x % 10;
    x /= 10;    
    //Console.WriteLine($" arr[{i}] = {arr[i]} ;  x = {x} ; i = {i}");
    summ = summ + arr[i];
    i++;
}

Console.WriteLine($" {number} -> {summ}");