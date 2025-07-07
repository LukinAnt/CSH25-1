/*
 Напишите программу, которая на вход принимает 
число и выдает его квадрат
4 - 16
-3  9
-7  49
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//для ввода числа с консоли
Console.WriteLine(number * number);