/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите целое число  > ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите еще одно целое число  > ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число  > ");
int с = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[] {a, b, с};
int i = 0;
int max = a;

while (i < 3) 
{ 
    if (numbers[i]> max) {
        max = numbers[i];
        i++; }
    else {i++;}
}

Console.WriteLine($"Наибольшее из заданных число {max}");
