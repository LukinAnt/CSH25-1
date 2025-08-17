/*
10. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторуюцифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трех значное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 99 && number1 < 1000)
{
    int num = number1 % 100 / 10;
    System.Console.WriteLine($"Вторая цифра {num}");
}
else
{System.Console.WriteLine("не трехзначное число");}