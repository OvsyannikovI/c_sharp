// Задача 56: Задайте прямоугольный двумерный
//  массив. Напишите программу, 
// которая будет находить строку с
//  наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов
//  в каждой строке и выдаёт номер строки 
//  с наименьшей суммой элементов: 1 строка

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

int[,] matrix = CreateArrayRndInt(4, 4, 0, 100);

int[] SumStrMatrix(int[,] inMatrix)
{
    int[] arr = new int[inMatrix.GetLength(0)];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            arr[i] = arr[i] + inMatrix[i,j];
        }
    }
    return arr;
}

int MaxElem(int[] arr)
{
    int max = arr[0];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max > arr[i])
        {
            max = arr[i];
            count = i;
        }
    }
    return count+1;
}

PrintArray(matrix);
Console.WriteLine($"Наименьшаю сумма: {MaxElem(SumStrMatrix(matrix))} строка");