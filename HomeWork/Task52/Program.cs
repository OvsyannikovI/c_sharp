// Задача 52. Задайте двумерный массив из
// целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

void SredArifm(int[,] matr)
{
    int[] sumCol = new int[4];

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int n = 0; n < matr.GetLength(0); n++)
        {
            sumCol[i] = sumCol[i] + matr[n,i];
        }
    }
    double sredAr1 = Convert.ToDouble(sumCol[0])/matr.GetLength(0);
    double sredAr2 = Convert.ToDouble(sumCol[1])/matr.GetLength(0);
    double sredAr3 = Convert.ToDouble(sumCol[2])/matr.GetLength(0);
    double sredAr4 = Convert.ToDouble(sumCol[3])/matr.GetLength(0);
    
    Console.WriteLine($"Среднее арифметическое каждого столбца: {sredAr1:##.#}; {sredAr2:##.#}; {sredAr3:##.#}; {sredAr4:##.#};");
}
SredArifm(matrix);