int number = new Random().Next(10, 100);
int MaxDigit (int num)
{   
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
// string result = firstDigit == secondDigit ? "Цифры равны" : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine($"Random number 10 - 99 => {number}");
// Console.WriteLine($"Max number {number} => {result}");
int result = MaxDigit(number);
string res = result == 0 ? "Цифры равны" : result.ToString();

Console.WriteLine("Введите координаты");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string GetQuarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Неверные координаты";
}

string result1 = GetQuarter(x, y);
Console.WriteLine(result1);

int i = 0;
string[] arr = new string[5];
while (i < arr.Length)
{
    Console.WriteLine($"Введите координаты {i + 1}: ");
    Console.Write("X: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int ya = Convert.ToInt32(Console.ReadLine());

    arr[i] = GetQuarter(xa, ya);
    Console.WriteLine(arr[i]);
    i++;
}
