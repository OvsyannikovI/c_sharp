// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] arr1 = {2, 3, 7};
int[] arr2 = {44, 5, 78};
int[] arr3 = {22, 3, 9};

int Max (int num1, int num2, int num3)
{
    int result = 0;
    if (num1 > result) result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}
 int max1 = Max(arr1[0],arr1[1],arr1[2]);
 int max2 = Max(arr2[0],arr2[1],arr2[2]);
 int max3 = Max(arr3[0],arr3[1],arr3[2]);

 Console.WriteLine($"Максимальное число и набора {String.Join(" ", arr1)} это {max1}");
 Console.WriteLine($"Максимальное число и набора {String.Join(" ", arr2)} это {max2}");
 Console.WriteLine($"Максимальное число и набора {String.Join(" ", arr3)} это {max3}");