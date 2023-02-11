//Задача 1: Задайте двумерный массив. Напишите программу, 
//которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

void OrderRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1 - k; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

OrderRows(array);
PrintArray(array);
