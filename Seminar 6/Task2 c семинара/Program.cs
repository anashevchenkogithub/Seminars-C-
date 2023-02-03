/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/

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

int[] FillArray(int arraylength, int minnumber, int maxnumber)
{
    int[] array = new int[arraylength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minnumber, maxnumber + 1);
    }
    return array;
}

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < (array.Length / 2); i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

int arraylength = InputInt("Введите длину массива ");
int minnumber = 1; //InputInt("Введите минимальный порог значений массива ");
int maxnumber = 9; //InputInt("Введите максимальный порог значений массива ");


int[] array = FillArray(arraylength, minnumber, maxnumber);

int[] reversedarray = Reverse(array);

PrintArray(array);

PrintArray(reversedarray);

PrintArray(Reverse(array));