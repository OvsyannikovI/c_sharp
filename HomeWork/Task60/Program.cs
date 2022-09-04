// Задача 60. ...Сформируйте трёхмерный массив
//  из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет 
//  построчно выводить массив, 
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArrayRndInt(int sizeStr, int sizeCol, int sizeTree, int min, int max)
{
    int[,,] array = new int[sizeStr, sizeCol, sizeTree];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = rnd.Next(min, max + 1);
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[i,n,j]} ({i},{n},{j} )");
            }
            Console.WriteLine();
        }
    }
}
int[,,] mt1 = CreateArrayRndInt( 2, 2, 2, 0, 100);
PrintArray(mt1);