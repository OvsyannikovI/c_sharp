// Задача 50. Напишите программу,
//  которая на вход принимает позиции
//   элемента в двумерном массиве,
//    и возвращает значение этого
//     элемента или же указание,
//      что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] matrix = new int[3, 4] {{1, 4, 7, 2},
                                {5, 9, 2, 3},
                                {8, 4, 2, 4}};

Console.WriteLine("Введите позицию элемента матрицы m и n");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintElemMatrix(int row, int col, int[,] matr)
{
    if (row > matr.GetLength(0) || col > matr.GetLength(1) || row < 0 || col < 0) Console.WriteLine($"{row}, {col} -> такого элемента в массиве нет");
    else 
    {
        Console.WriteLine($"{row}, {col} -> {matr[row,col]}");
    }
}
PrintElemMatrix(m,n, matrix);