/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

void PrintArrayDouble(double[,] array)
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

double[,] CreateMatrixDouble(int minnumber, int maxnumber)
{
    double[,] matrix = new double[3, 4];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((minnumber + rnd.NextDouble() * (maxnumber - minnumber)),1);
        }
    }
    return matrix;
}

int minnumber = -10; // InputInt("Введите минимальный порог значений массива ");
int maxnumber = 10; // InputInt("Введите максимальный порог значений массива ");

double[,] matrix = CreateMatrixDouble(minnumber, maxnumber);
PrintArrayDouble(matrix);
