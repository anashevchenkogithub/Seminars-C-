/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if ((i + 1) < array.Length)
        {
            Console.Write($", ");
        }
    }
    Console.Write($"]");
}

int[] FillArray(int arraylength, int minnumber, int maxnumber)
{
    int[] array = new int[arraylength];

    // заполнение массива

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minnumber, maxnumber + 1);
    }
    return array;
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int arraylength = InputInt("Введите длину массива ");
int minnumber = 100; //InputInt("Введите минимальный порог значений массива ");
int maxnumber = 999; //InputInt("Введите максимальный порог значений массива ");

int[] array = FillArray(arraylength, minnumber, maxnumber);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Количество четных элементов массива равно {CountEven(array)}");
