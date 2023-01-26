// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Реализовать через функции.

int InputInt(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int DigitsSum(int numberf)
{
    int n = numberf;
    int SumD = 0;
    while (n > 0)
    {
        int ost = n % 10;
        SumD = SumD + ost;
        n = n / 10;
    }
    return SumD;
}

int number = InputInt($"Введите целое положительное число");
int sum = DigitsSum(number);

Console.WriteLine($"В числе {number} сумма цифр равна {sum}");