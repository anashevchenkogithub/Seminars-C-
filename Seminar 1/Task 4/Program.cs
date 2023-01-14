/*  Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Введите целое положительное число  > ");
int a = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[a-1] ;
int i = 0;

while (i < a-1) 
{ Console.Write($"{i+2} ");
    i = i+2;
}