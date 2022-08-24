// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и
// минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]:##.##}, ");
        else Console.Write($"{array[i]:##.##}");
    }
    Console.Write("]");
}

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min;
    }
    return array;
}

void DiffMaxMinElem(double[] array)
{    
    double max = array[0];
    double min = array[0];
    double diff = double.NaN;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    Console.Write($" -> {diff:##.##}");
}

double[] arr = CreateArrayRndInt(4, 0, 100);
PrintArray(arr);
DiffMaxMinElem(arr);