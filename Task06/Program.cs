/*
напишите программу, которая на вход принимает число 
и выдает является ли число четным(делится ли оно на 2 без остатка
)
*/
Console.WriteLine("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = number1 % 2;
if (number2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
