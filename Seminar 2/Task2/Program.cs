/* Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int InputInt(string message)
{
    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int number = InputInt("Введите число > ");
if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }

    Console.WriteLine($"Третья цифра равна {number % 10}");
}
else
{
    Console.WriteLine($"Третьей цифры в числе {number} нет");
}