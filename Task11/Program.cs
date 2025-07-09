/*
11. 11. Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int first = number / 100;
int second = number % 10;
//Console.WriteLine(first);
//Console.WriteLine(second);
Console.WriteLine(first * 10 + second);
