/* Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int InputInt(string message)
{

    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InputInt("Введите трехзначное число > ");
if (a > 99 && a < 1000)
{
    int digit2 = ((a/10) % 10);
    
    Console.WriteLine($"Вторая цифра числа {a} равна {digit2}");
}
else
{
    Console.WriteLine($"Число {a} не является трехзначным");
}
