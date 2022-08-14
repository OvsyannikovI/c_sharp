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