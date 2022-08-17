// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] a = new int[3];
int[] b = new int[3];

Console.WriteLine("Введите координаты точек в 3D пространстве");

Console.Write("Ax: ");
a[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay: ");
a[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Az: ");
a[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Bx: ");
b[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("By: ");
b[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Bz: ");
b[2] = Convert.ToInt32(Console.ReadLine());

double getDistance(int[] xDot, int[] bDot)
{
    double res = Math.Sqrt(Math.Pow((bDot[0] - xDot[0]), 2) + 
                        Math.Pow((bDot[1] - xDot[1]), 2) +
                        Math.Pow((bDot[2] - xDot[2]), 2));
    return res;
}

double result = getDistance(a,b);

Console.Write($"A ( {a[0]}, {a[1]}, {a[2]}); B ( {b[0]}, {b[1]}, {b[2]}) -> {result:#.##}");