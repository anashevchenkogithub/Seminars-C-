/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
void PrintArray1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
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
double[] AverageColumns(int[,] matrix)
{
    double[] avcol = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum = sum + matrix[i,j];
        }
        avcol[j] = Math.Round(sum / matrix.GetLength(0), 1);
    }
    return avcol;
}

int row = InputInt($"Введите количество строк в таблице");
int column = InputInt($"Введите количество столбцов в таблице");
int minnumber = 0; //InputInt($"Введите минимально возможное значение");
int maxnumber = 10; //InputInt($"Введите максимально возможное значение");

int[,] table = CreateMatrix(row, column, minnumber, maxnumber);
PrintArray(table);

double[] avcol = AverageColumns(table);
Console.WriteLine("Среднее арифметическое по столбцам");
PrintArray1(avcol);
