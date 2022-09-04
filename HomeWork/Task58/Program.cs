// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateArrayRndInt(int sizeStr, int sizeCol, int min, int max)
{
    int[,] array = new int[sizeStr, sizeCol];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[i,n]} ");
        }
        Console.WriteLine();
    }
}

int[,] SumMatrix(int[,] arr1, int[,] arr2)
{
    int[,] rez = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                rez[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return rez;
}

int[,] matrix1 = CreateArrayRndInt(2, 2, 0, 100);
int[,] matrix2 = CreateArrayRndInt(2, 2, 0, 100);
// int [,] matrix1 = {{2, 4}, {3, 2}};
// int [,] matrix2 = {{3, 4}, {3, 3}};

Console.WriteLine("Матрица1: ");
PrintArray(matrix1);
Console.WriteLine("Матрица2:");
PrintArray(matrix2);
Console.WriteLine("Произведение матриц:");
PrintArray(SumMatrix(matrix1, matrix2));