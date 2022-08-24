// int number = new Random().Next(100, 1000);
// int sot = number / 100;
// int dec = (number - sot * 100)  / 10;
// int ed = (number - sot * 100 - dec * 10);
// int result = sot * 10 + ed;
// Console.WriteLine(number + " " + sot + " " + dec + " " + ed);
// Console.WriteLine(result);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }
    return new int[]{sumNeg, sumPos};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] sumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine($"Сумма отрицательных чисел = {sumPosNegElem[0]}");
Console.WriteLine($"Сумма положительных чисел = {sumPosNegElem[1]}");