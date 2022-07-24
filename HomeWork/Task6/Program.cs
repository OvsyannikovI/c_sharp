// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int num1 =4, num2 = -3, num3 = 7;

string EvenNumb (int arg)
{
    string yes = "Четное число", no = "Нечетное число";
    if (arg%2 == 0) return yes;
    else
    {
        return no;
    }
}

Console.WriteLine($"Число {num1} это - {EvenNumb(num1)}");
Console.WriteLine($"Число {num2} это - {EvenNumb(num2)}");
Console.WriteLine($"Число {num3} это - {EvenNumb(num3)}");