/** Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
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
    Console.WriteLine($"]");
}

int[] InputArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = InputInt("Введите число");
    }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int m = InputInt("Введите сколько будет всего чисел");
int[] array = InputArray(m);
PrintArray(array);
int count = CountPositive(array);
Console.WriteLine($"Было введено {count} положительных чисел");