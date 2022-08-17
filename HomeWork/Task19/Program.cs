// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");

int x = Convert.ToInt32(Console.ReadLine());

bool controlNumber(int num)
{   
    string number = num.ToString();
    if (number.Length != 5) return false;
    else return true;
}

if (!controlNumber(x))
{
    Console.WriteLine("Число не верно!");
}
else
{
    int oneNum = x/10000;
    int twoNum = x/1000%10;
    int fourNum = x/10%10;
    int fiveNum = x%10;
    // Console.WriteLine("1 number -> " + oneNum +
    //                     "\n2 number -> " + twoNum +
    //                      "\n4 number -> " + fourNum +
    //                       "\n5 number -> " + fiveNum);

    if (oneNum == fiveNum && twoNum == fourNum) Console.WriteLine($"{x} -> да");
    else Console.WriteLine($"{x} -> нет");    
}