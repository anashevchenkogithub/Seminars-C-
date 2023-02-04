/* Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание,
  что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int row, int column, int minnumber, int maxnumber)
{
    int[,] matrix = new int[row, column];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minnumber, maxnumber + 1);
        }
    }
    return matrix;
}

int row = InputInt($"Введите количество строк в таблице");
int column = InputInt($"Введите количество столбцов в таблице");
int minnumber = 0; //InputInt($"Введите минимально возможное значение");
int maxnumber = 10; //InputInt($"Введите максимально возможное значение");

int[,] table = CreateMatrix(row, column, minnumber, maxnumber);
PrintArray(table);

int ii = InputInt($"Введите номер строки искомого элемента") - 1;
int jj = InputInt($"Введите номер столбца искомого элемента") - 1;

if ((ii < row && jj < column))
{
    Console.WriteLine($"На пересечении строки {ii+1} и столбца {jj+1} находится число {table[ii,jj]}");
}
else
    Console.WriteLine("Такого числа нет в таблице");