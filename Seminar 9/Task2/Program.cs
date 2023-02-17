﻿/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumNumbers(int start, int finish)
{
    if (start > finish) return 0;
    return SumNumbers(start + 1, finish) + start;
}

Console.WriteLine(SumNumbers(4,8));