//введите трехзначное число и покажите последнюю цифру


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// защита от дурака на трехзначность
if (number > 99 && number < 1000)
{Console.WriteLine(number % 10);}
else
{Console.WriteLine("не трехзначное");}
