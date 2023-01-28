/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minnumber, maxnumber + 1);
    }
    return array;
}

int SumUnevenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int arraylength = InputInt("Введите длину массива ");
int minnumber = InputInt("Введите минимальный порог значений массива ");
int maxnumber = InputInt("Введите максимальный порог значений массива ");

int[] array = FillArray(arraylength, minnumber, maxnumber);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {SumUnevenPosition(array)}");
