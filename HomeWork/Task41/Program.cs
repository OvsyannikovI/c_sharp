// Задача 41: Пользователь вводит с
// клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {size} числа");
int[] ReadArray(int count)
{
    int[] arr = new int[count];
    int i = 0;
    while (i < count)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
}

void CountNumPolInArray (int[] array)
{
    int len = array.Length;
    int i = 0;
    int count = 0;
    while (i < len)
    {
        if (array[i] > 0) count++;
        i++;
    }
    Console.WriteLine($"-> {count}");
}

int[] array = ReadArray(size);

PrintArray(array);
CountNumPolInArray(array);