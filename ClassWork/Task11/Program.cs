int number = new Random().Next(100, 1000);
int sot = number / 100;
int dec = (number - sot * 100)  / 10;
int ed = (number - sot * 100 - dec * 10);
int result = sot * 10 + ed;
Console.WriteLine(number + " " + sot + " " + dec + " " + ed);
Console.WriteLine(result);