/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int k1 = InputInt($"Введите k1 - угол наклона первой прямой ");
int b1 = InputInt($"Введите b1 - смещение первой прямой по оси y");
int k2 = InputInt($"Введите k2 - угол наклона второй прямой ");
int b2 = InputInt($"Введите b2 - смещение второй прямой по оси y");

if (k1 == k2)
{
    Console.WriteLine($"Прямые параллельны и не пересекаются");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых - ({x},{y})");
}

