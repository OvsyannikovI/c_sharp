// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными
//  вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[i,n]:##.#} ");
            // if (n < array.GetLength(1)) Console.Write($"{array[i,n], 3} ");         
            // else Console.WriteLine($"{array[i,n], 3} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateMatrixRndInt(int sizeStr, int sizeCol, int min, int max)
{
    double[,] array = new double[sizeStr, sizeCol];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[i , n] = rnd.NextDouble()*(max - min) + min;
        }
    }
    return array;
}

Console.WriteLine("Введите размерность массива m*n");
Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrixRndInt(m, n, -100, 100);
PrintArray(matrix);