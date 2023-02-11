// Задача 2: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(1, 11);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

(int min, int minIndex) MinRowSum(int[,] arr)
{
    int[] sumRows = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sumRows[i] = sumRows[i] + arr[i, j];
    }
    int min = sumRows[0];
    int minIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (sumRows[i] < min) { min = sumRows[i]; minIndex = i; }
    }
    return (min, minIndex);
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

(int min, int minIndex) = MinRowSum(array);
Console.WriteLine($"Минимальная сумма элементов равна {min} и находится в строке {minIndex + 1}");
