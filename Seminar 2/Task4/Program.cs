/* Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа. Не использовать строки для расчета
 */


int number = new Random().Next(100, 1000);
int digit3 = number % 10;
int digit1 = number / 100;
int result = digit1 * 10 + digit3;
Console.WriteLine($"Сгенерировано число {number} > без второй цифры {result}");
