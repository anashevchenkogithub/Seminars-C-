/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double InputDouble(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToDouble(Console.ReadLine());
}

void PrintArray(double[] array)
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

double[] FillArrayDouble(int arraylength, double minnumber, double maxnumber)
{
    Random rand = new Random();
    double[] array = new double[arraylength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minnumber + rand.NextDouble() * (maxnumber - minnumber);
    }
    return array;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


int arraylength = InputInt("Введите длину массива ");
double minnumber = InputDouble("Введите минимальный порог значений массива ");
double maxnumber = InputDouble("Введите максимальный порог значений массива ");

double[] array = FillArrayDouble(arraylength, minnumber, maxnumber);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным элементом {FindMax(array)}  минимальным элементом {FindMin(array)} равна {(FindMax(array) - FindMin(array))}");
