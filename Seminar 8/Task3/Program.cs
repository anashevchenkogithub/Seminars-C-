// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

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

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] resultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return resultMatrix;
}

int rows1 = InputInt("Введите количество строк первой матрицы");
int columns1 = InputInt("Введите количество столбцов первой матрицы");
int rows2 = columns1;
int columns2 = InputInt("Введите количество столбцов второй матрицы");


int[,] matrix1 = new int[rows1, columns1];
int[,] matrix2 = new int[rows2, columns2];

FillArray(matrix1);
PrintArray(matrix1);

FillArray(matrix2);
PrintArray(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] multiplicatedMatrix = MultiplicationMatrix(matrix1, matrix2);
    Console.WriteLine("Перемноженная матрица:");
    PrintArray(multiplicatedMatrix);
}
else Console.WriteLine("Матрицы не могут быть перемножены: размерность не соответстует");
