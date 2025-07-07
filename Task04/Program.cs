/*
напишите программу, клторая принимает на вход три числа 
и выдает максимальное из них
2 3 7   7
44 5 78  78
22 3 9 22
*/

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
int min = number1;
if (number2 < min) min = number2;
if (number3 < min) min = number3;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);