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
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
}

int arraylength = InputInt("Введите длину массива ");

int[] array = new int[arraylength];
Random rnd = new Random();

// заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100);
    //    Console.WriteLine($"Элемент с индексом {i} равен {array[i]}");
}

PrintArray(array);