//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int InputInt(string message)
{

    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int DayNumber = InputInt("Введите число от 1 до 7, обозначающее день недели > ");

if (!(DayNumber > 7 || DayNumber < 1))
{
    if (DayNumber == 6 || DayNumber == 7)
    {
        Console.WriteLine($"Это выходной день");
    }
    else
    {
        Console.WriteLine($"Это будний день");
    }
}
else
{
    Console.WriteLine($"Число {DayNumber} не подходит");
}