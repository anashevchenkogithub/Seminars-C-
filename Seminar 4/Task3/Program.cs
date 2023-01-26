//|Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write($"Получился массив [");
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
        //    Console.WriteLine($"Элемент с индексом {i} равен {array[i]}");
    }
    return array;
}

int arraylength = InputInt("Введите длину массива ");
int minnumber = InputInt("Введите минимальный порог значений массива ");
int maxnumber = InputInt("Введите максимальный порог значений массива ");

int[] array = FillArray(arraylength, minnumber, maxnumber);
PrintArray(array);