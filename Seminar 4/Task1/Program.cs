// //Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Реализовать через функции.

int InputInt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeF(int numberf, int degreef)
{
    int result = 1;
    for (int i = 0; i < degreef; i++)
    {
        result = numberf * result;
    }
    return result;
}

int number = InputInt("Введите число ");
int degree = InputInt("Введите степень ");

int result = DegreeF(number, degree);

Console.WriteLine($"Число {number} в степени {degree} равно {result}");