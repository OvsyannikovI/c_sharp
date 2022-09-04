// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortMatrix(int[,] array)
{   
    int temp = 0;

    for (int a = 0; a <= (array.GetLength(0)*array.GetLength(1)); a++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if(array[i,j] < array[i,j+1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Введите размерность массива m*n");
Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArrayRndInt(m, n, 0, 100);

PrintArray(matrix);
Console.WriteLine("Сортировка: ");
PrintArray(SortMatrix(matrix));